$(function () {

    var service = new ServiceObject();
    service.Init();

    //初始化Table
    var table = new TableObject(service);
    table.Init();

    //初始化按钮
    var button = new ButtonObject(service);
    button.Init();


    var timer = new Timer(service, table.GetTable());
    var isOpen = new CheckBoxIsOpen(timer);
    isOpen.Init();
   
  
    
   
   
    String.prototype.format = function () {
        var args = arguments;
        return this.replace(/\{(\d+)\}/g,
            function (m, i) {
                return args[i];
            });
    }
});

var TableObject = function (service) {
    var table = new Object();
    table.$table = $('#tb_fruits');
    //初始化Table
    table.Init = function () {
        var editButton = "<button id='btnEdit' class='btn blue btn-sm' data-target='#CreateFruitModal' data-toggle='modal' title='编辑' data-id='{0}'><i class='glyphicon glyphicon-edit'></i>编辑</button>";
        var deleteButton = "<button id='btnDelete' class='btn red btn-sm' href='javascript:void(0)' title='删除' ><i class='glyphicon glyphicon-remove'></i>删除</button>";
        table.$table.bootstrapTable({
            url: 'TaoJinEarn/GetFruits',         //请求后台的URL（*）
            method: 'post',                      //请求方式（*）
            striped: true,                      //是否显示行间隔色
            dataType: "json",
            cache: false,                       //是否使用缓存，默认为true，所以一般情况下需要设置一下这个属性（*）
            sortable: false,                     //是否启用排序
            //sortOrder: "asc",                   //排序方式
            queryParams: table.queryParams,//传递参数（*）
            strictSearch: true,
            showColumns: true,                  //是否显示所有的列
            showRefresh: true,                  //是否显示刷新按钮
            minimumCountColumns: 2,             //最少允许的列数
            clickToSelect: true,                //是否启用点击选中行
            height: 900,                        //行高，如果没有设置height属性，表格自动根据记录条数觉得表格高度
            uniqueId: "id",                     //每一行的唯一标识，一般为主键列
            showToggle: true,                    //是否显示详细视图和列表视图的切换按钮
            cardView: false,                    //是否显示详细视图
            detailView: false,                //是否显示父子表
            columns: [
               {
                    field: "Operation",
                    title: "操作",
                    align: "center",
                    width: 160,
                    events: {
                        'click #btnEdit': function (e, value, row, index) {
                            
                        },
                        'click #btnDelete': function (e, value, row, index) {
                            abp.message.confirm("你确定要删除吗？", "提示", function (isConfirm) {
                                if (isConfirm) {
                                    //删除
                                    service.DeleteObject(row.Id).done(function () {
                                        location.reload(true);
                                    });
                                } else {
                                    
                                }
                            });
                        }
                    },
                    formatter: operateFormatter
               },
                {
                    field: "FruitCode",
                    title: "水果编码",
                    visible:false
                },
               {
                   field: "ImageUrl",
                   width: 53,
                   formatter:imageFormatter
               },
                {
                    field: "FruitName",
                    title: "水果名",
                    width: "20%",
                    align: "center"
                }, {
                    field: "CurrPrice",
                    title: "当前价格",
                    align: "center"
                }, {
                    field: "Volume",
                    title: "成交量",
                    align: "center"
                }
            ]
        });

        function operateFormatter(value, row, index) {
            return [
                editButton.format(row.Id),
                deleteButton
            ].join('&nbsp;');
        }

        function imageFormatter(value, row, index) {
            return " <img src='images/fruit/" + row.FruitCode + ".png' />";
        }
     
    };
    table.GetTable = function () {
        return table.$table;
    }

    //得到查询的参数
    table.queryParams = function (params) {
        var temp = {
            Sorting: "Order" //排序方式
        };
        return temp;
    };
    return table;
};


var ButtonObject = function (service) {
    var oInit = new Object();
    
    oInit.Init = function () {
        this.InitModalSubmit();
    };
    oInit.InitModalSubmit = function () {
        var _$modal = $('#CreateFruitModal');
        var _$form = _$modal.find('form');
        //初始化页面上面的按钮事件
        _$form.find('button[type="submit"]').click(function (e) {

            _$form.validate();

            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var fruit = _$form.serializeFormToObject();
            abp.ui.setBusy(_$modal);
            service.AddOrEditObject(fruit).done(function () {
                _$modal.modal('hide');
                location.reload(true);
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });

        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });
        //模态框显示
        _$modal.on('show.bs.modal', function (e) {
            var button = $(e.relatedTarget);
            var id = button.data('id');
            var modal = $(this);
            if (id != undefined && id != null && id != "") {
                //编辑
                //获取数据初始化信息
                service.GetFruitById(id).done(function (data) {
                    var obj = data;
                    //赋值
                    modal.find(".modal-body input[name='Id']").val(obj.id);
                    modal.find(".modal-body input[name='FruitName']").val(obj.fruitName);
                    
                });
                $(modal.find('.modal-title span')[0]).css("display", "none");
                $(modal.find('.modal-title span')[1]).css("display", "");
            } else {
                modal.find(".modal-body input[name='Id']").val("");
                $(modal.find('.modal-title span')[0]).css("display", "");
                $(modal.find('.modal-title span')[1]).css("display", "none");
            }
        });

    }

    return oInit;
};

//更新checkbox
var CheckBoxIsOpen = function (timer) {
    var obj = new Object();
    var $chk = $("#chkIsOpen");
    //绑定事件
    obj.Init = function () {
        $chk.click(function () {
            var checked=$chk.attr("checked");
            if (checked) {
                //启动数据请求
                timer.Start(3000);
            } else {
                //关闭数据请求
                timer.Stop(3000);
            }
        });
    }
    return obj;
}

var ServiceObject = function () {
    var service = new Object();
    //获取服务
    var _fruitService = abp.services.app.taoJin;
    //添加或者编辑
    service.AddOrEditObject = function (fruitobj) {
        return _fruitService.createOrUpdateFruit({
            fruit: fruitobj
        });
    }
    service.Init = function () {

    }
    //删除
    service.DeleteObject = function (id) {
        return _fruitService.deleteFruit({
            id:id
        });
    }
    service.GetFruitById = function (id) {
        return _fruitService.getFruitById({
            id:id
        });
    }
    //获取淘金农场数据
    service.GetSpiderFruits = function () {
        return _fruitService.getSpiderFruits();
    }
    return service;
}

//异步请求果园数据
var Timer = function (service,$table) {
    var obj = new Object();
    obj.isOpen = false;//默认不启动爬取数据
    var timer;
    obj.Start = function (timeout) {
        timer = $.timer(timeout, function () {
            service.GetSpiderFruits().done(function (data) {
                var items = data.items;
                //获取所有行
                var allTableData = $table.bootstrapTable('getData');
                //更新数据
                for (i = 0; i < allTableData.length; i++) {
                    var obj = items[i];
                    $table.bootstrapTable('updateRow', {
                        index: i,
                        row: {
                            CurrPrice: obj.price,
                            Volume: obj.volume
                        }
                    });

                }

            });
        });
    }
    //停止
    obj.Stop = function () {
        timer.stop();
    }
    //恢复
    obj.Reset = function (timeout) {
        obj.Stop();
        timer.reset(timeout);
    }
    return obj;
}



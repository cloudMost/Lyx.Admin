$(function () {

    //初始化Table
    var table = new TableObject();
    table.Init();

    //初始化Button的点击事件
    var button = new ButtonObject();
    button.Init();

    var service = new ServiceObject();
    service.Init();
   

});

var TableObject = function () {
    var table = new Object();
    
    //初始化Table
    table.Init = function () {
        $('#tb_novels').bootstrapTable({
            url: 'NovelSpider/GetNovels',         //请求后台的URL（*）
            method: 'post',                      //请求方式（*）
            striped: true,                      //是否显示行间隔色
            dataType: "json",
            cache: false,                       //是否使用缓存，默认为true，所以一般情况下需要设置一下这个属性（*）
            toolbar: '#tb_novels_toolbar',                //工具按钮用哪个容器
            pagination: true,                   //是否显示分页（*）
            sortable: false,                     //是否启用排序
            sortName:"Name",
            //sortOrder: "asc",                   //排序方式
            queryParams: table.queryParams,//传递参数（*）
            sidePagination: "server",           //分页方式：client客户端分页，server服务端分页（*）
            pageNumber:1,                       //初始化加载第一页，默认第一页
            pageSize: 1,                       //每页的记录行数（*）
            pageList: [1, 2, 3, 4],        //可供选择的每页的行数（*）
            strictSearch: true,
            showColumns: true,                  //是否显示所有的列
            showRefresh: true,                  //是否显示刷新按钮
            minimumCountColumns: 2,             //最少允许的列数
            clickToSelect: true,                //是否启用点击选中行
            height: 500,                        //行高，如果没有设置height属性，表格自动根据记录条数觉得表格高度
            uniqueId: "id",                     //每一行的唯一标识，一般为主键列
            showToggle: true,                    //是否显示详细视图和列表视图的切换按钮
            cardView: false,                    //是否显示详细视图
            detailView: false,                 //是否显示父子表
            paginationFirstText:"首页",
            paginationPreText:"上一页",
            paginationNextText:"下一页",
            paginationLastText: "尾页"
        });
    };

    //得到查询的参数
    table.queryParams = function (params) {
        var temp = {   
            MaxResultCount: params.limit,   //页面大小
            SkipCount: params.offset,  //页码
            Sorting:"Name" //排序方式
        };
        return temp;
    };
    return table;
};


var ButtonObject = function () {
    var oInit = new Object();
    var postdata = {};

    oInit.Init = function () {
        //初始化页面上面的按钮事件
    };

    return oInit;
};

var ServiceObject = function() {
    var service = new Object();
    service.Init = function () {
        //spider服务
        var _spiderService = abp.services.app.spider;
        var _$modal = $('#CreateNovelModal');
        var _$form = _$modal.find('form');
        console.log(_$form);
        _$form.validate();

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var spider = _$form.serializeFormToObject();

            abp.ui.setBusy(_$modal);
            _spiderService.createOrUpdateNovelSpider({
                novelSpider: spider
            }).done(function () {
                _$modal.modal('hide');
                location.reload(true); 
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });

        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });
    }
    return service;
}
$(function () {

    var service = new ServiceObject();
    service.Init();

 
    //初始化按钮
    var button = new ButtonObject(service);
    button.Init();


   
    String.prototype.format = function () {
        var args = arguments;
        return this.replace(/\{(\d+)\}/g,
            function (m, i) {
                return args[i];
            });
    }
});



var ButtonObject = function (service) {
    var oInit = new Object();
    
    oInit.Init = function () {
        this.InitModalSubmit();
    };
    oInit.InitModalSubmit = function () {
        var _$modal = $('#FruitSetForm');
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
                
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });
    }

    return oInit;
};



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





//Configuration setting for Test Manager application

var Test = new function (){
    var testName = "Test Manager";
    this.ShowTestName = function () {
        return testName;
    };
};

Test.UI = {};

Test.UI.Settings = {
    Scheme: "http:\\\\",
    Path: window.location.host,
    ServiceName: new Array(),
    FullPath: function () {
        return this.Scheme + this.Path + "\\";
    },
    ShowTestName: function () {
        return Test.ShowTestName();
    }
}

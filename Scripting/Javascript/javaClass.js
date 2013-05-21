var MyClass = {
    FirstName: "Arif",
    LastName: "Khan",
    MiddleName: "BanneHasan",
    ShowFullName: function() {
        alert(this.FirstName + " " + this.LastName + " " + this.MiddleName);
    },
    SetFName: function(v) { this.FirstName = v; },
    Browser: { FireFox: "fire", Mozilla: "Mozilla", Internet: "internet" }
};

MyClass.ShowFullName();
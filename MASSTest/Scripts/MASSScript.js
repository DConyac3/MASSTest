document.getElementById("CalcButton").addEventListener("click", function () {
    var val1 = document.getElementById("Field1").value;
    var val2 = document.getElementById("Field2").value;

    if (Number(val1) < 0) {
        if (Number(val2) < 0) {
            alert("Neither number can be negative. Aborting...");
        }
        else {
            alert("First value cannot be negative. Aborting...")
        }
        return;
    }
    if (Number(val2) < 0) {
        alert("Second value cannot be negative. Aborting...")
    }
}, false);
//делает readonly все контролы в строке таблицы
function tableRowDisabled(n, excludeControl) {
    var item = document.getElementById(n);
    if (item.classList.contains('table-secondary')) {
        item.classList.remove('table-secondary');
        enableElements(item.children);
    }
    else {
        item.classList.add('table-secondary');
        disableElements(item.children, excludeControl);
    }
}
function tableRowDisabledWithoutStyles(tablerow, excludeControl,checkbox)
{
    

    var item = document.getElementById(checkbox);

    if (item.checked) {
     
        enableElements(document.getElementById(tablerow).children);
    }
    else {
 
        disableElements(document.getElementById(tablerow).children, excludeControl);
    }
}
function disableElements(el, excludeControl) {
    for (var i = 0; i < el.length; i++)
    {
       
        if (el[i].id != excludeControl) {

            el[i].readOnly = true;
            disableElements(el[i].children, excludeControl);
        }


    }
}

function enableElements(el) {
    for (var i = 0; i < el.length; i++) {
        el[i].readOnly = false;

        enableElements(el[i].children);
    }
}
$(document).ready(function () {
    //$('#datatable').dataTable();
    $.ajax(
        {
            url: 'WebForm1.aspx/GetStaffInfo',
            method: 'post',
            dataType: 'json',
            contentType: 'application/json',
            async: false,
            success: function (data) {
                $('#datatable').dataTable({
                    data: JSON.parse(data.d),
                    columns: [
                        { 'data': 'Name' },
                        { 'data': 'ID' },
                        { 'data': 'Price' },
                        {
                            'data': 'ID', 'render':
                                function (data) {
                                    return '<button type="button" class="btn btn-primary" id="editAccountantID" onclick="editCustomer(' + data + ')">Edit</button> <button type="button" class="btn btn-primary" id="deleteItem" onclick="clearItem(' + data + ')">Delete</i></button>'
                                }
                        },

                    ],


                });
            }
        });
});
var ID;
function editCustomer(id) {

    $("#showDiv_edit").fadeIn();
    ID = id;
}

function edit_hidediv() {
    $("#showDiv_edit").fadeOut();
}

function EditItem() {
    var name = document.getElementById("TextBox_Name").value;
    var price = document.getElementById("TextBox_Price").value;
    var id = document.getElementById("TextBox_Id").value;

    $.ajax({
        url: 'WebForm1.aspx/EditItems',
        method: 'post',
        dataType: 'json',
        data: JSON.stringify({ "id": id, "name": name, "price": price }),
        contentType: 'application/json',
        async: false,
        success: function (data) {
            var table = $('#datatable').DataTable();
            table.destroy();
            $('#datatable').dataTable({
                data: JSON.parse(data.d),
                columns: [
                    { 'data': 'ID' },
                    { 'data': 'Name' },
                    { 'data': 'Price' },
                    {
                        'data': 'ID', 'render':
                            function (data) {
                                return '<button type="button" class="btn btn-primary" id="editAccountantID" onclick="editCustomer(' + data + ')">Edit</button> <button type="button" class="btn btn-primary" id="deleteItem" onclick="clearCustomer(' + data + ')">Delete</i></button>'
                            }
                    }
                ]
            });
        }

    });

}

function clearItem(id) {
    $.ajax({
        url: 'WebForm1.aspx/ClearItem',
        type: 'post',
        data: JSON.stringify({ "id": id }),
        contentType: 'application/json',
        async: false,
        success: function (data) {
            debugger
            var table = $('#datatable').DataTable();
            table.destroy();
            $('#datatable').dataTable({
                data: JSON.parse(data.d),
                columns: [
                    { 'data': 'ID' },
                    { 'data': 'Name' },
                    { 'data': 'Price' },
                    {
                        'data': 'ID', 'render':
                            function (data) {
                                return '<button type="button" class="btn btn-primary" id="editAccountantID" onclick="editCustomer(' + data + ')">Edit</button> <button type="button" class="btn btn-primary" id="deleteItem" onclick="clearItem(' + data + ')">Delete</i></button>'
                            }
                    }
                ]
            });


        }

    });

}
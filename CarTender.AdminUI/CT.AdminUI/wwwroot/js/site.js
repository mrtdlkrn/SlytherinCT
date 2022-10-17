$(document).ready(function () {
    $('#myTable').DataTable({
        "scrollY": "450px",
        "scrollCollapse": true,
        "paging": true,
        "language": {
            "sSearch": "Ara:",
            "lengthMenu": "Her sayfada _MENU_ satır göster",
            "zeroRecords": "Herhangi bir şey bulunamadı",
            "info": "_PAGE_ / _PAGES_",
            "infoEmpty": "Kayıt yok",
            "infoFiltered": "(_MAX_ kayıttan filtrelendi)",
            "oPaginate": {
                "sFirst": "İlk",
                "sLast": "Son",
                "sNext": "Sonraki",
                "sPrevious": "Önceki"
            },
            "sProcessing": "İşleniyor...",
            "sEmptyTable": "Kayıt yok",
            "sInfoPostFix": "",
            "sUrl": "",
            "sInfoThousands": ",",
            "sLoadingRecords": "Yükleniyor...",        
            "oAria": {
                "sSortAscending": ": Artan",
                "sSortDescending": ": Azalan"
            }
        }
    })
})
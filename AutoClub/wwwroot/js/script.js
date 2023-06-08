$(document).ready(function () {
    // * * * * * Range Slider * * * * *
    var $range = $(".js-range-slider"),
        $inputFrom = $(".js-input-from"),
        $inputTo = $(".js-input-to"),
        instance,
        min = 2000,
        max = 90000,
        from = 0,
        to = 0;

    $range.ionRangeSlider({
        skin: "round",
        type: "double",
        min: min,
        max: max,
        from: 2000,
        to: 90000,
        onStart: updateInputs,
        onChange: updateInputs
    });
    instance = $range.data("ionRangeSlider");

    function updateInputs(data) {
        from = data.from;
        to = data.to;

        $inputFrom.prop("value", from);
        $inputTo.prop("value", to);
    }

    $inputFrom.on("input", function () {
        var val = $(this).prop("value");

        // validate
        if (val < min) {
            val = min;
        } else if (val > to) {
            val = to;
        }

        instance.update({
            from: val
        });
    });

    $inputTo.on("input", function () {
        var val = $(this).prop("value");

        // validate
        if (val < from) {
            val = from;
        } else if (val > max) {
            val = max;
        }

        instance.update({
            to: val
        });
    });
    // * * * * * Owl Carousel * * * * *
    $("#FeaturedVehicles .owl-carousel").owlCarousel({
        loop: true,
        // margin: 10,
        nav: false,
        dots: false,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            },
            800: {
                items: 3
            },
            1000: {
                items: 4
            }
        }
    });

    // * * * * * Owl Carousel Custom Buttons * * * * *
    $("#FeaturedVehicles .cusPrevious").click(function () {
        $("#FeaturedVehicles .owl-prev").click();
    });
    $("#FeaturedVehicles .cusNext").click(function () {
        $("#FeaturedVehicles .owl-next").click();
    });

    // List / Grid View
    $(".viewList").click(function (event) {
        event.preventDefault();
        $(this).addClass("active");
        $(".viewTable").removeClass("active");

        $("#Items #All #Item").removeClass();
        $("#Items #All #Item").addClass("col-12");

        $("#Items #All #Item #ItemCart").removeClass();
        $("#Items #All #Item #ItemCart").addClass("itemCatr row w-100 ml-0");

        $("#Items #All #Item #ItemCart #ItemImg").removeClass();
        $("#Items #All #Item #ItemCart #ItemImg").addClass("item_img col-12 col-sm-6 px-0");

        $("#Items #All #Item #ItemCart #ItemInfo").removeClass();
        $("#Items #All #Item #ItemCart #ItemInfo").addClass("item_info col-12 col-sm-6");
    });

    $(".viewTable").click(function (event) {
        event.preventDefault();
        $(this).addClass("active");
        $(".viewList").removeClass("active");

        $("#Items #All #Item").removeClass();
        $("#Items #All #Item").addClass("col-12 col-md-6 col-lg-4");

        $("#Items #All #Item #ItemCart").removeClass();
        $("#Items #All #Item #ItemCart").addClass("itemCatr w-100");

        $("#Items #All #Item #ItemCart #ItemImg").removeClass();
        $("#Items #All #Item #ItemCart #ItemImg").addClass("item_img w-100");

        $("#Items #All #Item #ItemCart #ItemInfo").removeClass();
        $("#Items #All #Item #ItemCart #ItemInfo").addClass("item_info");
    });

    // Tab Form
    $(".lnk-2").click(function (event) {
        event.preventDefault();
        $(this).addClass("active");
        $(".lnk-1").removeClass("active");

        $(".frm-1").addClass("d-none");
        $(".frm-2").removeClass("d-none");
    });

    $(".lnk-1").click(function (event) {
        event.preventDefault();
        $(this).addClass("active");
        $(".lnk-2").removeClass("active");

        $(".frm-2").addClass("d-none");
        $(".frm-1").removeClass("d-none");
    });

    // FINANCING CALCULATOR
    $("#pymntbtn").click(function myFunction() {
        var loan = $("#amount").val(),
            month = $("#months").val(),
            int = $("#interest").val(),
            // years = $("#years").val(),
            down = $("#down").val(),
            amount = parseInt(loan),
            months = parseInt(month),
            down = parseInt(down),
            annInterest = parseFloat(int),
            monInt = annInterest / 1200,
            calculation = (
                (monInt + monInt / (Math.pow(1 + monInt, months) - 1)) *
                (amount - (down || 0))
            ).toFixed(2);

        if (!isNaN(calculation)) {
            document.getElementById("output").innerHTML = calculation;
        } else {
            document.getElementById("output").innerHTML = "00.0";
        }
    });

    $(function () {
        var month = $(this).val(),
            doneTypingInterval = 500,
            months = parseInt(month),
            typingTimer;

        $("#months").keyup(function () {
            month = $(this).val();
            months = parseInt(month);

            clearTimeout(typingTimer);
            if (month) {
                typingTimer = setTimeout(doneTyping, doneTypingInterval);
            }
        });

        function doneTyping() {
            $("#years").val(months / 12);
        }
    });

    $(function () {
        var month = $(this).val(),
            doneTypingInterval = 500,
            months = parseInt(month),
            typingTimer;

        $("#months").keyup(function () {
            month = $(this).val();
            months = parseInt(month);

            clearTimeout(typingTimer);
            if (month) {
                typingTimer = setTimeout(doneTyping, doneTypingInterval);
            }
        });

        function doneTyping() {
            $("#years").val(months / 12);
        }
    });

    $(function () {
        var year = $(this).val(),
            doneTypingInterval = 500,
            years = parseInt(year),
            typingTimer;

        $("#years").keyup(function () {
            year = $(this).val();
            myears = parseInt(year);

            clearTimeout(typingTimer);
            if (year) {
                typingTimer = setTimeout(doneTyping, doneTypingInterval);
            }
        });

        function doneTyping() {
            $("#months").val(year * 12);
        }
    });

    // About More Info Accordion
    $("#blckbut1").click(function () {
        $("#blck1").toggleClass("active");
    });
    $("#blckbut2").click(function () {
        $("#blck2").toggleClass("active");
    });
    $("#blckbut3").click(function () {
        $("#blck3").toggleClass("active");
    });

    // Submit Steps Controllers
    $("#stp1nxt2").click(moveToSecond);
    $("#stp2per1").click(previousToFirst);
    $("#stp2nxt3").click(moveToThird);
    $("#stp3per2").click(previousToSecond);
    $("#stp3nxt4").click(moveToFour);
    $("#stp4per3").click(previousToThird);
    $("#stp4nxt5").click(moveToFive);
    $("#stp5per4").click(previousToFour);

    function previousToFirst() {
        $("#Steps").attr("class", "move-to-first");

        $(".asider_step_triangle").removeClass("stp2");
        $(".asider_step_triangle").addClass("stp1");

        $(".aside_step1").addClass("active");
        $(".aside_step2").removeClass("active");
        $("#progstp2").removeClass("active");
    }

    function moveToSecond() {
        $("#Steps").attr("class", "move-to-second");

        $(".asider_step_triangle").removeClass("stp1");
        $(".asider_step_triangle").addClass("stp2");

        $(".aside_step2").addClass("active");
        $("#progstp2").addClass("active");
    }

    function previousToSecond() {
        $("#Steps").attr("class", "move-to-second");

        $(".asider_step_triangle").removeClass("stp3");
        $(".asider_step_triangle").addClass("stp2");

        $(".aside_step2").addClass("active");
        $(".aside_step3").removeClass("active");

        $("#progstp3").removeClass("active");
    }

    function moveToThird() {
        $("#Steps").attr("class", "move-to-third");

        $(".asider_step_triangle").removeClass("stp2");
        $(".asider_step_triangle").addClass("stp3");

        $(".aside_step3").addClass("active");
        $("#progstp3").addClass("active");
    }

    function previousToThird() {
        $("#Steps").attr("class", "move-to-third");

        $(".asider_step_triangle").removeClass("stp4");
        $(".asider_step_triangle").addClass("stp3");

        $(".aside_step3").addClass("active");
        $(".aside_step4").removeClass("active");

        $("#progstp4").removeClass("active");
    }

    function moveToFour() {
        $("#Steps").attr("class", "move-to-four");

        $(".asider_step_triangle").removeClass("stp3");
        $(".asider_step_triangle").addClass("stp4");

        $(".aside_step4").addClass("active");
        $("#progstp4").addClass("active");
    }

    function previousToFour() {
        $("#Steps").attr("class", "move-to-four");

        $(".asider_step_triangle").removeClass("stp5");
        $(".asider_step_triangle").addClass("stp4");

        $(".aside_step4").addClass("active");
        $(".aside_step5").removeClass("active");
        $("#progstp5").removeClass("active");
    }

    function moveToFive() {
        $("#Steps").attr("class", "move-to-five");

        $(".asider_step_triangle").removeClass("stp4");
        $(".asider_step_triangle").addClass("stp5");

        $(".aside_step5").addClass("active");
        $("#progstp5").addClass("active");
    }

    // * * * * * Vehicle Registration  Show/Hide * * * * *
    $("#regchck1").on("change", function () {
        if ($("input#regchck1:checked")) {
            $("#Step-4 .submitItem_reg").toggle();
        }
    });

    // * * * * * Cupon Code  Show/Hide * * * * *
    $("#Step-5 #cuponcode").on("change", function () {
        if ($("#Step-5 #cuponcode:checked")) {
            $("#Step-5 #CuponCodeInput").show();
            $("#Step-5 #Upbtn").hide();
        }
    });
    $("#Step-5 #creditcard").on("change", function () {
        if ($("#Step-5 #creditcard:checked")) {
            $("#Step-5 #CuponCodeInput").hide();
            $("#Step-5 #Upbtn").show();
        }
    });

    $("#PlanChange").click(function () {
        $(".submitItem_premiumlistings").toggle();
        $(".submitItem_freelistings").toggle();

        $("#freeplan").toggle();
        $("#premiumplan").toggle();
    });

    // * * * * * Members carousel * * * * *
    $("#AboutTeamMembers .owl-carousel").owlCarousel({
        loop: true,
        margin: 30,
        autoplay: true,
        responsive: {
            0: {
                items: 1
            },
            500: {
                items: 2
            },
            768: {
                items: 3
            },
            1000: {
                items: 4
            }
        }
    });

    // Add to Compare AJAX
    $(".addCompare").click(function (e) {
        e.preventDefault();

        toastr.options = {
            "closeButton": true,
            "positionClass": "toast-bottom-right",
        }

        $.ajax({
            url: $(this).attr("href"),
            method: "GET",
            success: function (res) {
                if (res.status === 200) {
                    toastr.success("Added to the comparison list successfully");
                }
                if (res.status === 410) {
                    toastr.warning("Already added");
                }
                if (res.status === 420) {
                    toastr.error("You have already added 3 vehicles");
                }
            }
        });
    });
    // Add to Favorite Vehicle AJAX
    $(".addFavoriteVehicle").click(function (e) {
        e.preventDefault();

        toastr.options = {
            "closeButton": true,
            "positionClass": "toast-bottom-right",
        }

        $.ajax({
            url: $(this).attr("href"),
            method: "GET",
            success: function (res) {
                if (res.status === 200) {
                    toastr.success("Added to favorites list successfully");
                }
                if (res.status === 430) {
                    toastr.warning("Already added");
                }
                if (res.status === 444) {
                    toastr.error("You need an account to add to the favorite");
                }
            }
        })
    });

    // Remove Favorite Vehicle AJAX
    $(".removefavorite").click(function (e) {
        e.preventDefault();
        var curThis = $(this);

        toastr.options = {
            "closeButton": true,
            "positionClass": "toast-bottom-right",
        }

        $.confirm({
            icon: 'fa fa-warning',
            title: 'Remove',
            content: 'Are you sure you want to remove it?',
            type: 'red',
            buttons: {
                Yes: {
                    text: 'Remove',
                    btnClass: 'btn-red',
                    action: function () {
                        $.ajax({
                            url: curThis.attr("href"),
                            method: "GET",
                            success: function (res) {
                                if (res.status === 200) {
                                    toastr.success("Successfully removed");
                                    curThis.parent().parent().parent().remove();
                                }
                            }
                        })
                    }
                },
                No: {
                    text: 'Cancel',
                    btnClass: 'btn-green',
                    action: function () {
                        //$.alert('Cancel');
                    }
                }
            }
        });
    })

    // Remove My Vehicle AJAX
    $(".removeMyVehicle").click(function (e) {
        e.preventDefault();

        var curThis = $(this);

        toastr.options = {
            "closeButton": true,
            "positionClass": "toast-bottom-right",
        }

        $.confirm({
            icon: 'fa fa-warning',
            title: 'Remove',
            content: 'Are you sure you want to remove it?',
            type: 'red',
            buttons: {
                Yes: {
                    text: 'Remove',
                    btnClass: 'btn-red',
                    action: function () {
                        $.ajax({
                            url: curThis.attr("href"),
                            method: "GET",
                            success: function (res) {
                                if (res.status === 200) {
                                    $.alert('Successfully removed');
                                    curThis.parent().parent().parent().parent().parent().parent().remove();
                                }
                            }
                        })
                    }
                },
                No: {
                    text: 'Cancel',
                    btnClass: 'btn-green',
                    action: function () {
                        //$.alert('Cancel');
                    }
                }
            }
        });
    });

    // Remove My Product AJAX
    $(".removeMyProduct").click(function (e) {
        e.preventDefault();

        var curThis = $(this);

        toastr.options = {
            "closeButton": true,
            "positionClass": "toast-bottom-right",
        }

        $.confirm({
            icon: 'fa fa-warning',
            title: 'Remove',
            content: 'Are you sure you want to remove it?',
            type: 'red',
            buttons: {
                Yes: {
                    text: 'Remove',
                    btnClass: 'btn-red',
                    action: function () {
                        $.ajax({
                            url: curThis.attr("href"),
                            method: "GET",
                            success: function (res) {
                                if (res.status === 200) {
                                    $.alert('Successfully removed');
                                    curThis.parent().parent().parent().parent().parent().parent().remove();
                                }
                            }
                        })
                    }
                },
                No: {
                    text: 'Cancel',
                    btnClass: 'btn-green',
                    action: function () {
                        //$.alert('Cancel');
                    }
                }
            }
        });
    });

    // Add To Basket AJAX
    $(".addbasket").click(function (e) {
        e.preventDefault();
        toastr.options = {
            "closeButton": true,
            "positionClass": "toast-bottom-right",
        }
        $.ajax({
            url: $(this).attr("href"),
            method: "GET",
            success: function (res) {
                if (res.status === 200) {
                    toastr.success("Added to the basket successfully");
                }
                if (res.status === 421) {
                    toastr.warning("No more products");
                }
                if (res.status === 422) {
                    toastr.error("You need an account to add to the shopping cart");
                }
            }
        });
    })

    // Remove Basket AJAX
    $(".removebasket").click(function (e) {
        e.preventDefault();
        var curThis = $(this);
        toastr.options = {
            "closeButton": true,
            "positionClass": "toast-bottom-right",
        }
        $.ajax({
            url: $(this).attr("href"),
            method: "GET",
            success: function (res) {
                if (res.status === 200) {
                    curThis.parent().parent().remove();
                    toastr.success("Successfully removed");
                }
            }
        });
    })

    // * * * * * File Upload * * * * *
    $("#select_submitImages").on("change", function () {
        const photoList = [...inputfile.files];
        selectedFiles = inputfile.files.length;
        fromImg.innerHTML = "";
        loadPhotos(photoList);
    });
});

// * * * * * File Upload * * * * *
let inputfile = document.getElementById("select_submitImages");
let fromImg = document.getElementById("UploadImg");
let selectedFiles;

// inputfile.onchange = function() {
//   const photoList = [...inputfile.files];
//   selectedFiles = inputfile.files.length;
//   fromImg.innerHTML = "";
//   loadPhotos(photoList);
// };

function loadPhotos(photoList) {
    if (selectedFiles > 5) {
        document.getElementById("Errortxt").innerText =
            "Up to 5 images can be selected";
        return;
    }

    for (var i = 0; i < selectedFiles; i++) {
        if (photoList[i].type.includes("image/")) {
            const div = document.createElement("div");
            div.classList.add("submitItemImage");
            const img = document.createElement("img");
            img.src = URL.createObjectURL(event.target.files[i]);
            div.appendChild(img);
            fromImg.appendChild(div);
        }
    }
    document.getElementById("Errortxt").innerText = "";
}

$("input.quantity").change(function () {
    $(this).parent().next().text($(this).parent().prev().text() * $(this).val())
});

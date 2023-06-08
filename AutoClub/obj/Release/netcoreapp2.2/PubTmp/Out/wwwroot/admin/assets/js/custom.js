/*
=========================================
|                                       |
|           Scroll To Top               |
|                                       |
=========================================
*/
$('.scrollTop').click(function () {
    $("html, body").animate({ scrollTop: 0 });
});


$('.navbar .dropdown.notification-dropdown > .dropdown-menu, .navbar .dropdown.message-dropdown > .dropdown-menu ').click(function (e) {
    e.stopPropagation();
});

/*
=========================================
|                                       |
|       Multi-Check checkbox            |
|                                       |
=========================================
*/

function checkall(clickchk, relChkbox) {

    var checker = $('#' + clickchk);
    var multichk = $('.' + relChkbox);


    checker.click(function () {
        multichk.prop('checked', $(this).prop('checked'));
    });
}


/*
=========================================
|                                       |
|           MultiCheck                  |
|                                       |
=========================================
*/

/*
    This MultiCheck Function is recommanded for datatable
*/

function multiCheck(tb_var) {
    tb_var.on("change", ".chk-parent", function () {
        var e = $(this).closest("table").find("td:first-child .child-chk"), a = $(this).is(":checked");
        $(e).each(function () {
            a ? ($(this).prop("checked", !0), $(this).closest("tr").addClass("active")) : ($(this).prop("checked", !1), $(this).closest("tr").removeClass("active"))
        })
    }),
        tb_var.on("change", "tbody tr .new-control", function () {
            $(this).parents("tr").toggleClass("active")
        })
}

/*
=========================================
|                                       |
|           MultiCheck                  |
|                                       |
=========================================
*/

function checkall(clickchk, relChkbox) {

    var checker = $('#' + clickchk);
    var multichk = $('.' + relChkbox);


    checker.click(function () {
        multichk.prop('checked', $(this).prop('checked'));
    });
}

/*
=========================================
|                                       |
|               Tooltips                |
|                                       |
=========================================
*/

$('.bs-tooltip').tooltip();

/*
=========================================
|                                       |
|               Popovers                |
|                                       |
=========================================
*/

$('.bs-popover').popover();


/*
================================================
|                                              |
|               Rounded Tooltip                |
|                                              |
================================================
*/

$('.t-dot').tooltip({
    template: '<div class="tooltip status rounded-tooltip" role="tooltip"><div class="arrow"></div><div class="tooltip-inner"></div></div>'
})


/*
================================================
|            IE VERSION Dector                 |
================================================
*/

function GetIEVersion() {
    var sAgent = window.navigator.userAgent;
    var Idx = sAgent.indexOf("MSIE");

    // If IE, return version number.
    if (Idx > 0)
        return parseInt(sAgent.substring(Idx + 5, sAgent.indexOf(".", Idx)));

    // If IE 11 then look for Updated user agent string.
    else if (!!navigator.userAgent.match(/Trident\/7\./))
        return 11;

    else
        return 0; //It is not IE
}


//
//* * * Users AJAX * * *
// Make Company Ajax
$(".makecompany").click(function (e) {
    e.preventDefault();
    var curThis = $(this);

    swal({
        title: 'Are you sure?',
        text: "Make Company",
        type: 'warning',
        showCancelButton: true,
        confirmButtonText: 'Yes',
        padding: '2em'
    }).then(function (result) {
        if (result.value) {
            swal(
                'Successed!',
                '',
                'success',
                $.ajax({
                    url: curThis.attr("href"),
                    method: "GET",
                    success: function (res) {
                        if (res.status === 200) {
                            curThis.parent().parent().remove();
                        }
                    }
                })
            )
        }
    })
})

// Make Member Ajax
$(".makemember").click(function (e) {
    e.preventDefault();
    var curThis = $(this);

    swal({
        title: 'Are you sure?',
        text: "Make Member",
        type: 'warning',
        showCancelButton: true,
        confirmButtonText: 'Yes',
        padding: '2em'
    }).then(function (result) {
        if (result.value) {
            swal(
                'Successed!',
                '',
                'success',
                $.ajax({
                    url: curThis.attr("href"),
                    method: "GET",
                    success: function (res) {
                        if (res.status === 200) {
                            curThis.parent().parent().remove();
                        }
                    }
                })
            )
        }
    })
})

// Delete User Ajax
$(".deleteuser").click(function (e) {
    e.preventDefault();
    var curThis = $(this);

    swal({
        title: 'Are you sure?',
        text: "These user and their vehicles will be completely removed!",
        type: 'error',
        showCancelButton: true,
        confirmButtonText: 'Delete',
        padding: '2em'
    }).then(function (result) {
        if (result.value) {
            $.ajax({
                url: curThis.attr("href"),
                method: "GET",
                success: function (res) {
                    if (res.status === 200) {
                        curThis.parent().parent().remove();
                        swal(
                            'Deleted!',
                            'User and vehicles removed',
                            'success',
                        )
                    }
                }
            })
        }
    })
})

//* * * Company AJAX * * *
// Delete Company Ajax
$(".deletedcompany").click(function (e) {
    e.preventDefault();
    var curThis = $(this);

    swal({
        title: 'Are you sure?',
        text: "These user and their products will be completely removed!",
        type: 'error',
        showCancelButton: true,
        confirmButtonText: 'Delete',
        padding: '2em'
    }).then(function (result) {
        if (result.value) {
            swal(
                'Deleted!',
                'User and products removed',
                'success',
                $.ajax({
                    url: curThis.attr("href"),
                    method: "GET",
                    success: function (res) {
                        if (res.status === 200) {
                            curThis.parent().parent().remove();
                        }
                    }
                })
            )
        }
    })
})

//* * * Member AJAX * * *
// Make User Ajax
$(".makeuser").click(function (e) {
    e.preventDefault();
    var curThis = $(this);

    swal({
        title: 'Are you sure?',
        text: "Make User",
        type: 'warning',
        showCancelButton: true,
        confirmButtonText: 'Yes',
        padding: '2em'
    }).then(function (result) {
        if (result.value) {
            swal(
                'Successed!',
                '',
                'success',
                $.ajax({
                    url: curThis.attr("href"),
                    method: "GET",
                    success: function (res) {
                        if (res.status === 200) {
                            curThis.parent().parent().remove();
                        }
                    }
                })
            )
        }
    })
})

//Make Admin Ajax
$(".makeadmin").click(function (e) {
    e.preventDefault();
    var curThis = $(this);

    swal.mixin({
        input: 'password',
        confirmButtonText: 'Next',
        showCancelButton: true,
        progressSteps: ['1', '2'],
        padding: '2em',
    }).queue([
        {
            title: 'Your Email',
            text: ''
        },
        'Password',
    ]).then(function (result) {
        if (result.value) {
            $.ajax({
                type: "Post",
                url: "ConfirmYourAdmin",
                data: { emailorpassword: result.value },
                success: function (res) {
                    if (res.status === 200) {
                        $.ajax({
                            url: curThis.attr("href"),
                            method: "GET",
                            success: function (res) {
                                if (res.status === 200) {
                                    curThis.parent().parent().remove();
                                    swal({
                                        title: 'Successful',
                                        text: "",
                                        type: 'success',
                                        padding: '2em'
                                    })
                                }
                            }
                        })
                    }
                    if (res.status === 400) {
                        swal({
                            title: 'Email or Password incorrect!',
                            text: "!",
                            type: 'error',
                            padding: '2em'
                        })
                    }
                }
            })

        }
    })
})

// Delete User Ajax
$(".deleteuserm").click(function (e) {
    e.preventDefault();
    var curThis = $(this);

    swal({
        title: 'Are you sure?',
        text: "!",
        type: 'error',
        showCancelButton: true,
        confirmButtonText: 'Delete',
        padding: '2em'
    }).then(function (result) {
        if (result.value) {
            swal(
                'Deleted!',
                'Member removed',
                'success',
                $.ajax({
                    url: curThis.attr("href"),
                    method: "GET",
                    success: function (res) {
                        if (res.status === 200) {
                            curThis.parent().parent().remove();
                        }
                    }
                })
            )
        }
    })
})

//* * * Admin AJAX * * *
// Make User Ajax
$(".umakeuser").click(function (e) {
    e.preventDefault();
    var curThis = $(this);

    swal.mixin({
        input: 'password',
        confirmButtonText: 'Next',
        showCancelButton: true,
        progressSteps: ['1', '2'],
        padding: '2em',
    }).queue([
        {
            title: 'Email',
            text: ''
        },
        'Password',
    ]).then(function (result) {
        if (result.value) {
            $.ajax({
                type: "Post",
                url: curThis.attr("href"),
                data: { emailandpassword: result.value },
                success: function (res) {
                    if (res.status === 200) {
                        $.ajax({
                            url: "UMakeUser/" + res.data,
                            method: "GET",
                            success: function (res) {
                                if (res.status === 200) {
                                    curThis.parent().parent().remove();
                                    swal({
                                        title: 'Successful',
                                        text: "",
                                        type: 'success',
                                        padding: '2em'
                                    })
                                }
                            }
                        })
                    }
                    if (res.status === 400) {
                        swal({
                            title: 'Email or Password incorrect!',
                            text: "!",
                            type: 'error',
                            padding: '2em'
                        })
                    }
                }
            })

        }
    })
})

// Make Member Ajax
$(".umakemember").click(function (e) {
    e.preventDefault();
    var curThis = $(this);

    swal.mixin({
        input: 'password',
        confirmButtonText: 'Next',
        showCancelButton: true,
        progressSteps: ['1', '2'],
        padding: '2em',
    }).queue([
        {
            title: 'Email',
            text: ''
        },
        'Password',
    ]).then(function (result) {
        if (result.value) {
            $.ajax({
                type: "Post",
                url: curThis.attr("href"),
                data: { emailandpassword: result.value },
                success: function (res) {
                    if (res.status === 200) {
                        $.ajax({
                            url: "UMakeMember/" + res.data,
                            method: "GET",
                            success: function (res) {
                                if (res.status === 200) {
                                    curThis.parent().parent().remove();
                                    swal({
                                        title: 'Successful',
                                        text: "",
                                        type: 'success',
                                        padding: '2em'
                                    })
                                }
                            }
                        })
                    }
                    if (res.status === 400) {
                        swal({
                            title: 'Email or Password incorrect!',
                            text: "!",
                            type: 'error',
                            padding: '2em'
                        })
                    }
                }
            })

        }
    })
})

// Delete Admin Ajax
$(".deleteusera").click(function (e) {
    e.preventDefault();
    var curThis = $(this);

    swal.mixin({
        input: 'password',
        confirmButtonText: 'Next',
        showCancelButton: true,
        progressSteps: ['1', '2'],
        padding: '2em',
    }).queue([
        {
            title: 'Email',
            text: ''
        },
        'Password',
    ]).then(function (result) {
        if (result.value) {
            $.ajax({
                type: "Post",
                url: curThis.attr("href"),
                data: { emailandpassword: result.value },
                success: function (res) {
                    if (res.status === 200) {
                        $.ajax({
                            url: "DeleteUser/" + res.data,
                            method: "GET",
                            success: function (res) {
                                if (res.status === 200) {
                                    curThis.parent().parent().remove();
                                    swal({
                                        title: 'Successfully removed',
                                        text: "",
                                        type: 'success',
                                        padding: '2em'
                                    })
                                }
                            }
                        })
                    }
                    if (res.status === 400) {
                        swal({
                            title: 'Email or Password incorrect!',
                            text: "!",
                            type: 'error',
                            padding: '2em'
                        })
                    }
                }
            })

        }
    })
})
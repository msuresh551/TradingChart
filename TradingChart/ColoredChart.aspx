<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ColoredChart.aspx.cs" Inherits="TradingChart.ColoredChart" %>

<!DOCTYPE html>

<!DOCTYPE html>
<html>
<script src="https://code.jquery.com/jquery-1.12.4.min.js" integrity="sha256-ZosEbRLbNQzLpnKIkEdrPv7lOy9C27hHQ+Xp8a4MxAQ=" crossorigin="anonymous"></script>
<head>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.6/angular.min.js"></script>
    <script src="https://s3-us-west-2.amazonaws.com/s.cdpn.io/374756/zingchart-2.1.4.min.js"></script>
    <script src="https://s3-us-west-2.amazonaws.com/s.cdpn.io/374756/zingchart-angularjs-1.0.4.js"></script>

    <script type="text/javascript">
        function method1() {
            var result = $('.nifty').val();
            result = result.split(',');
            var scriptname = $('#txtScriptID').val();
            scriptname = scriptname;
            var result2 = result.map(function (x) {
                return parseFloat(x, 10);
            });
            alert(result2);
            var app = angular.module('myApp', ['zingchart-angularjs']);
            app.controller('MainController', function ($scope) {
                $scope.myJson = {
                    gui: {
                        contextMenu: {
                            button: {
                                visible: 0
                            }
                        }
                    },
                    backgroundColor: "#434343",
                    globals: {
                        shadow: false,
                        fontFamily: "Helvetica"
                    },
                    type: "area",

                    legend: {
                        layout: "x4",
                        backgroundColor: "transparent",
                        borderColor: "transparent",
                        marker: {
                            borderRadius: "50px",
                            borderColor: "transparent"
                        },
                        item: {
                            fontColor: "white"
                        }

                    },
                    scaleX: {
                        maxItems: 6,
                        transform: {
                            type: 'time'
                        },
                        zooming: true,
                        values: [
                          '9:00', '9:30', '10:00', '10:30', '11:00', '11:30', '12:00', '12:30', '01:00', '01:30', '02:00', '02:30', '03:00', '03:30'
                        ],
                        lineColor: "white",
                        lineWidth: "1px",
                        tick: {
                            lineColor: "white",
                            lineWidth: "1px"
                        },
                        item: {
                            fontColor: "white"
                        },
                        guide: {
                            visible: false
                        }
                    },
                    scaleY: {
                        title:"Price",
                        lineColor: "white",
                        lineWidth: "1px",
                        tick: {
                            lineColor: "white",
                            lineWidth: "1px"
                        },
                        guide: {
                            lineStyle: "solid",
                            lineColor: "#626262"
                        },
                        item: {
                            fontColor: "white"
                        },
                        //transform: {
                        //    type: 'float'
                        //},
                        values: [8500, 8525, 8550, 8575, 8600],

                    },
                    tooltip: {
                        visible: false
                    },
                    crosshairX: {
                        scaleLabel: {
                            backgroundColor: "#fff",
                            fontColor: "black"
                        },
                        plotLabel: {
                            backgroundColor: "#434343",
                            fontColor: "#FFF",
                            _text: "Number of hits : %v"
                        }
                    },
                    plot: {
                        lineWidth: "2px",
                        aspect: "spline",
                        marker: {
                            visible: true
                        }
                    },
                    series: [{
                        text: "NIFTY-INTRA DAY CHART",
                        transform: {
                            type: 'float'
                        },
                        values: [8562.7, 8587.45, 8574.35, 8545.25, 8524.1, 8527.6, 8519, 8514.95, 8539, 8550.95, 8555, 8550.95, 8534.9, 8538.3],
                        backgroundColor1: "#77d9f8",
                backgroundColor2: "#272822",
                lineColor: "#40beeb"
            }]
        };
        });
        }
    </script>

    <%--Existing Code--%>
    <%--
       
        <script type="text/javascript">
        var app = angular.module('myApp', ['zingchart-angularjs']);

        app.controller('MainController', function ($scope) {

            $scope.myJson = {
                gui: {
                    contextMenu: {
                        button: {
                            visible: 0
                        }
                    }
                },
                backgroundColor: "#434343",
                globals: {
                    shadow: false,
                    fontFamily: "Helvetica"
                },
                type: "area",

                legend: {
                    layout: "x4",
                    backgroundColor: "transparent",
                    borderColor: "transparent",
                    marker: {
                        borderRadius: "50px",
                        borderColor: "transparent"
                    },
                    item: {
                        fontColor: "white"
                    }

                },
                scaleX: {
                    maxItems: 8,
                    transform: {
                        type: 'date'
                    },
                    zooming: true,
                    values: [
                      1442905200000, 1442908800000,
                      1442912400000, 1442916000000,
                      1442919600000, 1442923200000,
                      1442926800000, 1442930400000,
                      1442934000000, 1442937600000,
                      1442941200000, 1442944800000,
                      1442948400000
                    ],
                    lineColor: "white",
                    lineWidth: "1px",
                    tick: {
                        lineColor: "white",
                        lineWidth: "1px"
                    },
                    item: {
                        fontColor: "white"
                    },
                    guide: {
                        visible: false
                    }
                },
                scaleY: {
                    lineColor: "white",
                    lineWidth: "1px",
                    tick: {
                        lineColor: "white",
                        lineWidth: "1px"
                    },
                    guide: {
                        lineStyle: "solid",
                        lineColor: "#626262"
                    },
                    item: {
                        fontColor: "white"
                    },
                },
                tooltip: {
                    visible: false
                },
                crosshairX: {
                    scaleLabel: {
                        backgroundColor: "#fff",
                        fontColor: "black"
                    },
                    plotLabel: {
                        backgroundColor: "#434343",
                        fontColor: "#FFF",
                        _text: "Number of hits : %v"
                    }
                },
                plot: {
                    lineWidth: "2px",
                    aspect: "spline",
                    marker: {
                        visible: false
                    }
                },
                series: [{
                    text: "All Sites",
                    values: [2596, 2626, 4480,
                             6394, 7488, 14510,
                             7012, 10389, 12281,
                             15597, 17500, 15500,
                             16002, 17000, 15000],
                    backgroundColor1: "#77d9f8",
                    backgroundColor2: "#272822",
                    lineColor: "#40beeb"
                }]
            };
        });

    </script>--%>
    <style type="text/css">
        html, body {
            margin: 0px;
        }
    </style>
</head>
<body ng-app="myApp">

    <form id="form1" runat="server">
        <div>
            <asp:DropDownList runat="server" ID="ddlscript" OnSelectedIndexChanged="ddlscript_SelectedIndexChanged" AutoPostBack="true">
            </asp:DropDownList>
            <asp:TextBox runat="server" ID="txtScriptID" />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <asp:TextBox Class="nifty" ID="TextBox1" runat="server" Width="700"></asp:TextBox>
        </div>
        <div ng-controller="MainController">
            <div zingchart id="chart-1" zc-json="myJson" zc-width="90%" zc-height="400x"></div>
        </div>
    </form>
    <!-- <link rel="stylesheet"  type="text/html"  href="http://codepen.io/zingchart/pen/epvRNK">  -->
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HighChartWithDesign.aspx.cs" Inherits="TradingChart.HighChartWithDesign" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<script src="https://code.jquery.com/jquery-1.12.4.min.js" integrity="sha256-ZosEbRLbNQzLpnKIkEdrPv7lOy9C27hHQ+Xp8a4MxAQ=" crossorigin="anonymous"></script>
<script src="https://code.highcharts.com/highcharts.js"></script>
<script src="https://code.highcharts.com/modules/exporting.js"></script>
<head runat="server">
    <title></title>
    <script>
        Highcharts.createElement('link', {
            href: 'https://fonts.googleapis.com/css?family=Dosis:400,600',
            rel: 'stylesheet',
            type: 'text/css'
        }, null, document.getElementsByTagName('head')[0]);

        Highcharts.theme = {
            colors: ["#7cb5ec", "#f7a35c", "#90ee7e", "#7798BF", "#aaeeee", "#ff0066", "#eeaaee",
               "#55BF3B", "#DF5353", "#7798BF", "#aaeeee"],
            chart: {
                backgroundColor: "#7798BF",
                style: {
                    fontFamily: "Dosis, sans-serif"
                }
            },
            title: {
                style: {
                    fontSize: '16px',
                    fontWeight: 'bold',
                    textTransform: 'uppercase'
                }
            },
            tooltip: {
                borderWidth: 0,
                backgroundColor: 'rgba(219,219,216,0.8)',
                shadow: false
            },
            legend: {
                itemStyle: {
                    fontWeight: 'bold',
                    fontSize: '13px'
                }
            },
            xAxis: {
                gridLineWidth: 1,
                labels: {
                    style: {
                        fontSize: '12px'
                    }
                }
            },
            yAxis: {
                minorTickInterval: 'auto',
                title: {
                    style: {
                        textTransform: 'uppercase'
                    }
                },
                labels: {
                    style: {
                        fontSize: '12px'
                    }
                }
            },
            plotOptions: {
                candlestick: {
                    lineColor: '#404048'
                }
            },


            // General
            background2: '#F0F0EA'

        };

    </script>

    <script>

        function method1() {

            var result = $('.nifty').val();
            result = result.split(',');
            var scriptname = $('#txtScriptID').val();
            scriptname = scriptname;
            var result2 = result.map(function (x) {
                return parseFloat(x, 10);
            });
            $('#container').highcharts({
                chart: {
                    backgroundColor: '#ECF2D9',
                    type: 'line'
                },
                title: {
                    text: 'Today NIFTY- Monday, 12 September 2016  '
                },
                subtitle: {
                    text: scriptname + '- Chart of the Day'
                },
                xAxis: {
                    categories: ['9:00', '9:30', '10:00', '10:30', '11:00', '11:30', '12:00', '12:30', '01:00', '01:30', '02:00', '02:30', '03:00', '03:30']
                },
                yAxis: {
                    title: {
                        text: 'PRICE'
                    }
                },
                plotOptions: {
                    line: {
                        dataLabels: {
                            enabled: true
                        },
                        enableMouseTracking: false
                    }
                },
                series: [{
                    //   type: 'candlestick',
                    name: scriptname,
                    //data: [245.6, 244, 243.9, 243.4, 242.75, 242.95, 243.4, 244.2, 243.55, 243.35]
                    //data: [8343.4, 8318.05, 8302.6, 8307.65, 8305.6, 8311.25, 8309.5, 8307, 8315.7, 8322.5, 8323.7, 8323.45, 8322.75, 8323.20]
                    data: result2
                }],
                threshold: 8550,
                negativeColor: 'green',
                color: 'red',

            });
            //second chart
            $('#container1').highcharts({
                chart: {
                    type: 'line'
                },
                title: {
                    text: 'Monthly Average Temperature'
                },
                subtitle: {
                    text: 'Source: WorldClimate.com'
                },
                xAxis: {
                    categories: ['9:00', '9:30', '10:00', '10:30', '11:00', '11:30', '12:00', '12:30', '01:00', '01:30', '02:00', '02:30', '03:00', '03:30']
                },
                yAxis: {
                    title: {
                        text: 'Temperature (°C)'
                    }
                },
                plotOptions: {
                    line: {
                        dataLabels: {
                            enabled: true
                        },
                        enableMouseTracking: false
                    }
                },
                series: [{
                    name: 'NIFTY',
                    data: result2
                }],
                backgroundColor: '#9395AE'

            });

            //styles
            Highcharts.createElement('link', {
                href: 'https://fonts.googleapis.com/css?family=Dosis:400,600',
                rel: 'stylesheet',
                type: 'text/css'
            }, null, document.getElementsByTagName('head')[0]);



        }
        //$(function () {
        //    $('#container').highcharts({
        //        chart: {
        //            type: 'line'
        //        },
        //        title: {
        //            text: 'Today NIFTY-Friday, 8 July 2016'
        //        },
        //        subtitle: {
        //            text: 'National Stock Exchange-Chart of the Day'
        //        },
        //        xAxis: {
        //            categories: ['9:00', '9:30', '10:00', '10:30', '11:00', '11:30', '12:00', '12:30', '01:00', '01:30', '02:00', '02:30', '03:00', '03:30']
        //        },
        //        yAxis: {
        //            title: {
        //                text: 'PRICE'
        //            }
        //        },
        //        plotOptions: {
        //            line: {
        //                dataLabels: {
        //                    enabled: true
        //                },
        //                enableMouseTracking: false
        //            }
        //        },
        //        series: [{
        //            //type: 'candlestick',
        //            name: 'NIFTY',
        //            //data: [245.6, 244, 243.9, 243.4, 242.75, 242.95, 243.4, 244.2, 243.55, 243.35]
        //            data: [8343.4, 8318.05, 8302.6, 8307.65, 8305.6, 8311.25, 8309.5, 8307, 8315.7, 8322.5, 8323.7, 8323.45, 8322.75, 8323.20]
        //        }]
        //    });
        //});
    </script>
</head>
<body>

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div>
                    <asp:DropDownList runat="server" ID="ddlscript" OnSelectedIndexChanged="ddlscript_SelectedIndexChanged" AutoPostBack="true">
                    </asp:DropDownList>
                    <asp:TextBox runat="server" ID="txtScriptID" />
                    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                    <asp:TextBox Class="nifty" ID="TextBox1" runat="server" Width="700"></asp:TextBox>
                </div>

                <div id="container" style="min-width: 310px; height: 400px; margin: 0 auto"></div>
                <br />
                <div id="container1" style="min-width: 310px; height: 400px; margin: 0 auto"></div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>


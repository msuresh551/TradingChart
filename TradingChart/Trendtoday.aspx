<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trendtoday.aspx.cs" Inherits="TradingChart.Trendtoday" %>

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

        function CYIENT() {
            Infosys();
            Mindtree();
            JustDial();
            WIPRO();
            WOCKPHARMA();
            DRREDDY();
            SUNPHARMA();
            LUPIN();
            CIPLA();
            var result = $('.txtCyient').val();
            result = result.split(',');
            var result2 = result.map(function (x) {
                return parseFloat(x, 10);
            });

            $('#Cyient').highcharts({
                chart: {
                    backgroundColor: '#ECF2D9',
                    type: 'line'
                },
                title: {
                    text: 'Cyient Ltd'
                },
                subtitle: {
                    text: 'Cyient Ltd- Chart of the Day'
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
                    name: 'CYIENT',
                    data: result2
                }],
                threshold: 8550,
                negativeColor: 'green',
                color: 'red',

            });


            //styles
            Highcharts.createElement('link', {
                href: 'https://fonts.googleapis.com/css?family=Dosis:400,600',
                rel: 'stylesheet',
                type: 'text/css'
            }, null, document.getElementsByTagName('head')[0]);
        }
        function Infosys() {
            var infyresult = $('.txtInfy').val();
            infyresult = infyresult.split(',');
            var result123 = infyresult.map(function (x) {
                return parseFloat(x, 10);
            });

            $('#INFY').highcharts({
                chart: {
                    backgroundColor: '#ECF2D9',
                    type: 'line'
                },
                title: {
                    text: 'Infosys Ltd'
                },
                subtitle: {
                    text: 'Chart of the day'
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
                    name: 'Infosys Ltd',
                    data: result123
                }],
                backgroundColor: '#9395AE'

            });
        }
        function Mindtree() {
            var infyresult = $('.txtMindTree').val();
            infyresult = infyresult.split(',');
            var result123 = infyresult.map(function (x) {
                return parseFloat(x, 10);
            });

            $('#MINDTREE').highcharts({
                chart: {
                    backgroundColor: '#ECF2D9',
                    type: 'line'
                },
                title: {
                    text: 'MindTree Ltd'
                },
                subtitle: {
                    text: 'Chart of the day'
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
                    name: 'MindTree Ltd',
                    data: result123
                }],
                backgroundColor: '#9395AE'

            });
        }
        function JustDial() {
            var infyresult = $('.txtJustDial').val();
            infyresult = infyresult.split(',');
            var result123 = infyresult.map(function (x) {
                return parseFloat(x, 10);
            });

            $('#JUSTDIAL').highcharts({
                chart: {
                    backgroundColor: '#ECF2D9',
                    type: 'line'
                },
                title: {
                    text: 'Just Dial Ltd'
                },
                subtitle: {
                    text: 'Chart of the day'
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
                    name: 'Just Dial Ltd',
                    data: result123
                }],
                backgroundColor: '#9395AE'

            });
        }
        function WIPRO() {
            var infyresult = $('.txtWipro').val();
            infyresult = infyresult.split(',');
            var result123 = infyresult.map(function (x) {
                return parseFloat(x, 10);
            });

            $('#WIPRO').highcharts({
                chart: {
                    backgroundColor: '#ECF2D9',
                    type: 'line'
                },
                title: {
                    text: 'Wipro Limited'
                },
                subtitle: {
                    text: 'Chart of the day'
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
                    name: 'Wipro Limited',
                    data: result123
                }],
                backgroundColor: '#9395AE'

            });
        }
        function WOCKPHARMA() {
            var infyresult = $('.txtWockPharma').val();
            infyresult = infyresult.split(',');
            var result123 = infyresult.map(function (x) {
                return parseFloat(x, 10);
            });

            $('#WOCKPHARMA').highcharts({
                chart: {
                    backgroundColor: '#ECF2D9',
                    type: 'line'
                },
                title: {
                    text: 'Wockhardt Limited'
                },
                subtitle: {
                    text: 'Chart of the day'
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
                    name: 'Wockhardt Limited',
                    data: result123
                }],
                backgroundColor: '#9395AE'

            });
        }

        function DRREDDY() {
            var infyresult = $('.txtDRREDDY').val();
            infyresult = infyresult.split(',');
            var result123 = infyresult.map(function (x) {
                return parseFloat(x, 10);
            });

            $('#DRREDDY').highcharts({
                chart: {
                    backgroundColor: '#ECF2D9',
                    type: 'line'
                },
                title: {
                    text: 'Dr.Reddys Laboratories Ltd'
                },
                subtitle: {
                    text: 'Chart of the day'
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
                    name: 'Dr.Reddys Laboratories Ltd',
                    data: result123
                }],
                backgroundColor: '#9395AE'

            });
        }
        function SUNPHARMA() {
            var infyresult = $('.txtSUNPHARMA').val();
            infyresult = infyresult.split(',');
            var result123 = infyresult.map(function (x) {
                return parseFloat(x, 10);
            });

            $('#SUNPHARMA').highcharts({
                chart: {
                    backgroundColor: '#ECF2D9',
                    type: 'line'
                },
                title: {
                    text: 'Sun Pharmaceutical Industries Ltd.'
                },
                subtitle: {
                    text: 'Chart of the day'
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
                    name: 'Sun Pharmaceutical Industries Ltd.',
                    data: result123
                }],
                backgroundColor: '#9395AE'

            });
        }
        function CIPLA() {
            var infyresult = $('.txtCipla').val();
            infyresult = infyresult.split(',');
            var result123 = infyresult.map(function (x) {
                return parseFloat(x, 10);
            });

            $('#CIPLA').highcharts({
                chart: {
                    backgroundColor: '#ECF2D9',
                    type: 'line'
                },
                title: {
                    text: 'Cipla Ltd'
                },
                subtitle: {
                    text: 'Chart of the day'
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
                    name: 'Cipla Ltd',
                    data: result123
                }],
                backgroundColor: '#9395AE'

            });
        }
        function LUPIN() {
            var infyresult = $('.txtLUPIN').val();
            infyresult = infyresult.split(',');
            var result123 = infyresult.map(function (x) {
                return parseFloat(x, 10);
            });

            $('#LUPIN').highcharts({
                chart: {
                    backgroundColor: '#ECF2D9',
                    type: 'line'
                },
                title: {
                    text: 'LUPIN Ltd'
                },
                subtitle: {
                    text: 'Chart of the day'
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
                    name: 'LUPIN Ltd',
                    data: result123
                }],
                backgroundColor: '#9395AE'

            });
        }
    </script>
</head>
<body>

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <%--<div>
                    <asp:DropDownList runat="server" ID="ddlscript" OnSelectedIndexChanged="ddlscript_SelectedIndexChanged" AutoPostBack="true">
                    </asp:DropDownList>
                    <asp:TextBox runat="server" ID="txtScriptID" />
                    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                   
                </div>--%>

                <table>
                    <%--IT industry--%>
                    <tr>
                        <td>
                            <div id="Cyient" style="width: 610px; height: 300px; margin: 0 auto"></div>
                            <asp:TextBox Class="txtCyient" ID="txtCyient" runat="server" Width="650" Visible="true"></asp:TextBox>
                        </td>
                        <td>
                            <div id="INFY" style="width: 610px; height: 300px; margin: 0 auto"></div>
                            <asp:TextBox Class="txtInfy" ID="txtInfosys" runat="server" Width="650" Visible="true"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <div id="JUSTDIAL" style="width: 610px; height: 300px; margin: 0 auto"></div>
                            <asp:TextBox Class="txtJustDial" ID="txtJustDial" runat="server" Width="650" Visible="true" />
                        </td>
                        <td>
                            <div id="MINDTREE" style="width: 610px; height: 300px; margin: 0 auto"></div>
                            <asp:TextBox Class="txtMindTree" ID="txtMindTree" runat="server" Width="650" Visible="true" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div id="WIPRO" style="width: 610px; height: 300px; margin: 0 auto"></div>
                            <asp:TextBox Class="txtWipro" ID="txtWipro" runat="server" Width="650" Visible="true" />
                        </td>
                        <td>
                            <div id="WOCKPHARMA" style="width: 610px; height: 300px; margin: 0 auto"></div>
                            <asp:TextBox Class="txtWockPharma" ID="txtWockPharma" runat="server" Width="650" Visible="true" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div id="DRREDDY" style="width: 610px; height: 300px; margin: 0 auto"></div>
                            <asp:TextBox Class="txtDRREDDY" ID="txtDRREDDY" runat="server" Width="650" Visible="true" />
                        </td>
                        <td>
                            <div id="CIPLA" style="width: 610px; height: 300px; margin: 0 auto"></div>
                            <asp:TextBox Class="txtCipla" ID="txtCipla" runat="server" Width="650" Visible="true" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div id="LUPIN" style="width: 610px; height: 300px; margin: 0 auto"></div>
                            <asp:TextBox Class="txtLUPIN" ID="txtLUPIN" runat="server" Width="650" Visible="true" />
                        </td>
                        <td>
                            <div id="SUNPHARMA" style="width: 610px; height: 300px; margin: 0 auto"></div>
                            <asp:TextBox Class="txtSUNPHARMA" ID="txtSUNPHARMA" runat="server" Width="650" Visible="true" />
                        </td>
                    </tr>
                </table>

                <br />

            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>


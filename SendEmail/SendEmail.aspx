<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendEmail.aspx.cs" Inherits="SendEmail.SendEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
    <script src="/Content/bootstrap.min.js"></script>
    <style>
        #gridView1 {
            direction: rtl;
        }

        #gridView2 {
            direction: rtl;
        }

        #btnSend {
            width: 100%;
        }
        .form-control {
            margin: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" style="direction: rtl">
            <div class="jumbotron">
                <h3>ارسال ایمیل و معرفی اماکن توریستی</h3>
                <span>فرم ارسال ایمیل</span>
            </div>
            <div runat="server" ID="divMessage" class="alert alert-danger">
                موبایل خود را وارد کنید
                <br/>
                حداقل یک تور را انتخاب کنید
            </div>
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h4>اطلاعات تماس</h4>
                </div>
                <div class="panel-body">
                    <div class="col-md-10">
                        <div class="form-group">
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtEmail" placeholder="ایمیل" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group" >
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtFullName" placeholder="نام و نام خانوادگی" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group" >
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtMobile" placeholder="موبایل" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group" >
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtNationalCode" placeholder="کد ملی" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group" >
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtProvince" placeholder="استان" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group" >
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtCity" placeholder="شهرستان" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group" >
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtRegion" placeholder="منطقه" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group" >
                            <div class="col-sm-9">
                                <asp:TextBox CssClass="form-control" ID="txtDistrict" placeholder="محله" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h4>خدمات تورهای نیم روزه (تور مورد نظر خود را انتخاب نمایید)</h4>
                </div>
                <div class="panel-body">
                    <asp:GridView runat="server" ID="gridView1" CssClass="table table-hover" OnRowDataBound="gridView1_RowDataBound">
                    </asp:GridView>
                </div>
            </div>
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h4>خدمات تورهای یک روزه (تور مورد نظر خود را انتخاب نمایید)</h4>
                </div>
                <div class="panel-body">
                    <asp:GridView runat="server" ID="gridView2" CssClass="table table-hover" OnRowDataBound="gridView2_RowDataBound">
                    </asp:GridView>
                </div>
            </div>
            <div class="row">
                <div class="form-group">
                    <div class="col-sm-12">
                        <asp:Button runat="server" CssClass="btn btn-lg btn-success" ID="btnSend" Text="ثبت درخواست تور" OnClick="btnSend_OnClick" />
                    </div>
                </div>
            </div>
            <br />
            <br />
            <br />
            <br />

        </div>

    </form>
</body>
</html>

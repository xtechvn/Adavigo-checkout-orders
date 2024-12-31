using System;
using System.Collections.Generic;
using System.Text;

namespace APP.CHECKOUT_SERVICE.Model
{
    public static class EmailTemplateStaticModel
    {
        public static string FlybookingB2C = @"
<!DOCTYPE html>
<html lang=""vi"" xmlns=""http://www.w3.org/1999/xhtml"">

<head>
    <meta name=""viewport"" content=""width=device-width;initial-scale=1, minimum-scale=1, maximum-scale=1, user-scalable=yes"">
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <title>Email Order Notification</title>
    <style>
        * {
            margin: 0;
            padding: 0;
            -webkit-box-sizing: border-box;
            box-sizing: border-box;
        }

        .btn-default {
            display: inline-block;
            color: #fff;
            font-size: 16px;
            font-weight: 500;
            line-height: 40px;
            border-radius: 10px;
            padding: 0 24px;
            text-align: center;
            background: #FF5B00;
            transition: 0.2s all;
            border: 1px solid #FF5B00;
            cursor: pointer;
        }

            .btn-default.gray {
                background: #E3EBF3;
                color: #00264D;
                border: 1px solid #E3EBF3;
            }

            .btn-default.full {
                width: 100%;
            }

        table td {
            padding: 6px 10px;
            vertical-align: top;
        }
    </style>
</head>

<body class="""" style=""background-color: #ffffff; font-family: sans-serif; -webkit-font-smoothing: antialiased; font-size: 16px; line-height: 27px; margin: 0; padding: 0; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"">

    <div style=""width: 700px; max-width: 100%;margin: 20px auto;color: #00264D;font-size:16px;background: #fff"">
        <table cellspacing=""0"" cellpadding=""0"" width=""100%"" style=""background: #F1F5F9;border-top: 3px solid #070BA0;padding:5px 15px;"">
            <tr>
                <td><img alt="""" src=""https://static-image.adavigo.com/uploads/images/logo.png""></td>
                <td style=""text-align: right""><img alt="""" src=""https://static-image.adavigo.com/uploads/images/hotline.png""></td>
            </tr>
        </table>
        <div style=""padding: 15px;"">
            <!--table thông tin order-->
            <table cellspacing=""0"" cellpadding=""0"" width=""100%"">
                <tr>
                    <td colspan=""4"">
                        Chào quý khách, <strong>{{customerName}}</strong>
                        <br />
                        Xin cảm ơn quý khách đã sử dụng dịch vụ của Adavigo
                        <br />
                        <br />
                        Mã đơn hàng: <strong style=""font-weight: bold; color: #ff5b00; font-size: 20px;"">{{orderNo}}</strong>
                        <strong style=""background: #FFEFD7;border-radius: 6px;padding: 4px 8px;color: #D09111;margin-left:10px; font-size: 14px;"">
                            {{keepTicketTime}}
                        </strong>
                        <strong style=""border-radius: 6px;padding: 4px 8px;color: red;margin-left:10px; font-size:14px !important"">
                            {{keepTicketTimeText}}
                        </strong>
                        <br />
                        <br />
                        <div style=""border-bottom:1px solid #E3EBF3;""></div>
                    </td>
                </tr>
                <tr style="" white-space: nowrap;"">
                    <td style=""color: #698096;"">Ngày đặt</td>
                    <td style=""color: #698096;"">Khách hàng</td>
                    <td style=""color: #698096;"">Số điện thoại</td>
                    <td style=""color: #698096;"">Email</td>
                </tr>
                <tr style="" white-space: nowrap;"">
                    <td>{{orderDate}}</td>
                    <td>{{customerName}}</td>
                    <td>{{phone}}</td>
                    <td><a style=""color: #1254FF"">{{email}}</a></td>
                </tr>
            </table>
            <!--end table thông tin order-->
            <!--table thông tin khách hàng-->
            <table cellspacing=""0"" cellpadding=""0"" width=""100%"">
                <tr>
                    <td colspan=""4"">
                        <div style=""font-size: 18px;""><strong>Thông tin hành khách</strong></div>
                    </td>
                </tr>
                <tr style=""background: #F1F5F9;"" class=""text-nowrap"">
                    <td style=""color: #698096;"">STT</td>
                    <td style=""color: #698096;white-space: nowrap;"">Tên hành khách</td>
                    <td style=""color: #698096;white-space: nowrap;"">Giới tính</td>
                    <td style=""color: #698096;white-space: nowrap;"">Ngày sinh</td>
                    <td style=""color: #698096;white-space: nowrap;"">Hành lý</td>
                </tr>
                {{passengerList}}
            </table>
            <!--end table thông tin hành khách-->
            <!--table thông tin chuyến bay đi - về-->
            <table cellspacing=""0"" cellpadding=""0"" width=""100%"">
                <tr style=""{{isDisplayGo}}"">
                    <td colspan=""4"">
                        <div style=""border-bottom:1px solid #E3EBF3""></div>
                    </td>
                </tr>
                <tr style=""{{isDisplayGo}}"">
                    <td colspan=""2"">
                        <div style=""font-size: 18px;""><strong>Thông tin chuyến bay đi</strong></div>
                        {{dayGo}}, ngày {{dateGo}}
                    </td>
                    <td colspan=""2"" style=""text-align: right"">
                        Mã đặt chỗ chiều đi: <strong style=""color: #FF5B00;font-size:18px"">{{flyOrderNoGo}}</strong>
                    </td>
                </tr>
                <tr style=""background: #F1F5F9;border-radius: 8px;{{isDisplayGo}}"">
                    <td colspan=""4"">
                        <!--<img alt="""" width=""40"" height=""40"" src=""{{logoAirlineGo}}"" style=""float: left; background-size: cover; background-image: url({{logoAirlineGo}}); "">-->
                        <img alt="""" src=""{{logoAirlineGo}}"" style="" height: 24px; max-width: 50px; max-height: 40px; "">
                        <span style=""margin-left:6px"">{{flyNameGo}}</span>
                        <span style=""margin-left:6px"">Chuyến bay</span>
                        <strong style=""margin-left:6px;color:#FF5B00"">{{flyCodeGo}}</strong>
                    </td>
                </tr>
                <tr style=""{{isDisplayGo}}"">
                    <td style=""vertical-align: middle;"">
                        <div><strong style=""font-size: 20px"">{{timeFromGo}}</strong></div>
                        {{addressGoFrom}}
                    </td>
                    <td style=""vertical-align: middle;"">
                        <img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/fly.png"">
                    </td>
                    <td style=""vertical-align: middle;"">
                        <div><strong style=""font-size: 20px"">{{timeToGo}}</strong></div>
                        {{addressGoTo}}
                    </td>
                    <td style=""vertical-align: middle;color: #698096;"">
                        <strong style=""color: #1254FF;background: #E6F7FF;border-radius: 4px;padding:4px"">EA</strong>
                        Hạng vé: {{flyTicketClassGo}}
                    </td>
                </tr>
                <tr style=""{{isDisplayBack}}"">
                    <td colspan=""4"">
                        <div style=""border-bottom:1px solid #E3EBF3;margin-bottom: 10px""></div>
                    </td>
                </tr>
                <tr style=""{{isDisplayBack}}"">
                    <td colspan=""2"">
                        <div style=""font-size: 18px;""><strong>Thông tin chuyến bay về</strong></div>
                        {{dayBack}}, ngày {{dateBack}}
                    </td>
                    <td colspan=""2"" style=""text-align: right"">
                        Mã đặt chỗ chiều về: <strong style=""color: #FF5B00;font-size:18px"">{{flyOrderNoBack}}</strong>
                    </td>
                </tr>
                <tr style=""background: #F1F5F9;border-radius: 8px; {{isDisplayBack}}"">
                    <td colspan=""4"">
                        <!--<img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/bamboo.png"" style=""float: left;"">-->
                        <!--<img alt="""" width=""40"" height=""40"" src=""{{logoAirlineBack}}"" style=""float: left; background-size: cover; background-image: url({{logoAirlineGo}}); "">-->
                        <img alt="""" "" src=""{{logoAirlineBack}}"" style="" height: 24px; max-width: 50px; max-height: 40px; "">
                        <span style=""margin-left:6px"">{{flyNameBack}}</span>
                        <span style=""margin-left:6px"">Chuyến bay</span>
                        <strong style=""margin-left:6px;color:#FF5B00"">{{flyCodeBack}}</strong>
                    </td>
                </tr>
                <tr style=""{{isDisplayBack}}"">
                    <td style=""vertical-align: middle;"">
                        <div><strong style=""font-size: 20px"">{{timeFromBack}}</strong></div>
                        {{addressBackFrom}}
                    </td>
                    <td style=""vertical-align: middle;""><img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/fly.png""></td>
                    <td style=""vertical-align: middle;"">
                        <div><strong style=""font-size: 20px"">{{timeToBack}}</strong></div>
                        {{addressBackTo}}
                    </td>
                    <td style=""vertical-align: middle;color: #698096;"">
                        <strong style=""color: #1254FF;background: #E6F7FF;border-radius: 4px;padding:4px"">EA</strong>
                        Hạng vé: {{flyTicketClassBack}}
                    </td>
                </tr>
                <tr>
                    <td colspan=""4"">
                        <div style=""border-bottom:1px solid #E3EBF3""></div>
                    </td>
                </tr>
                <tr>
                    <td colspan=""2"">
                        <div><strong>Thanh toán</strong></div>
                        Đã bao gồm VAT
                    </td>
                    <td colspan=""2"" style=""text-align: right"">
                        <strong style=""font-size:18px"">{{total}} đ</strong>
                    </td>
                </tr>
            </table>
            <!--end table thông tin chuyến bay đi - về-->
            <div style=""width: 100%;margin-top: 20px;"">
                <div style=""padding: 25px;background: #F1F5F9 url(https://static-image.adavigo.com/uploads/images/email/fly2.png) no-repeat right 20px top 20px;border-radius: 20px;margin-bottom: 25px"">
                    <table cellspacing=""0"" cellpadding=""0"" width=""100%"">
                        <tr>
                            <td colspan=""3"">
                                <div style=""font-size: 24px;""><strong>Thanh toán</strong></div>
                                Số tiền cần thanh toán: <strong style=""color:#FF5B00"">{{amount}} đ</strong>
                            </td>
                        </tr>
                        <tr>
                            <td colspan=""3"" style=""text-align:center"">
                                <span style=""background: #FFEFD7;border-radius: 6px;padding: 5px 8px;color: #D09111;font-size: 14px;"">
                                    <img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/warring.png"">&nbsp;
                                    Lưu ý: Vui lòng chuyển đúng đến 3 số cuối
                                </span>
                            </td>
                        </tr>
                    </table>
                    <div style=""background: #FFFFFF;border-radius: 20px;padding: 20px"">
                        <table cellspacing=""0"" cellpadding=""0"" style=""width: 100%;color: #00264D;font-size:16px;"">
                            <tr>
                                <td style=""width:100px"">
                                    <strong style=""background: #00A86B;border-radius: 66px;padding: 2px 8px;color: #fff;display: block;text-align: center;"">Cách 1</strong>
                                </td>
                                <td colspan=""2"" style="""">
                                    <strong>Thanh toán VnPay - QR/ Thẻ ATM Nội Địa / Thẻ Visa / Master</strong> <br />
                                    <div style=""color: #698096;margin-bottom: 10px"">Adavigo sẽ thu hộ phí qua cổng thanh toán</div>
                                    <a href=""{{payLink}}"" class=""btn-default""
                                       style=""width: 210px; text-decoration: none; color: #fff !important;"">Thanh toán</a>
                                </td>
                            </tr>
                            <tr>
                                <td style=""width:100px"">
                                    <strong style=""background: #00A86B;border-radius: 66px;padding: 2px 8px;color: #fff;display: block;text-align: center;"">Cách 2</strong>
                                </td>
                                <td>
                                    <strong>Nội dung chuyển khoản ghi rõ:</strong> <br />
                                </td>
                                <td>
                                    <strong>{{orderNo}} thanh toan</strong><br />
                                </td>
								<th rowspan=""4"">
									<div style=""text-align:center""><img alt="""" style=""max-width:202px;"" src=""{{LinkQR}}""></div>
									<div style=""text-align:center""><strong>Quét mã QR để thanh toán </strong></div>
									<div style=""text-align:center;color: #698096;"">Sử dụng internet banking hoặc ứng dụng hỗ trợ QR code để quét mã</div>		
								</th>
                            </tr>
                            <tr>
                                <td style=""width:100px"">
                                </td>
                                <td>
                                    <div style=""color: #698096;"">Ngân hàng/chi nhánh</div>
                                </td>
                                <td><strong>Ngân Hàng TMCP Kỹ Thương Việt Nam chi nhánh Đông Đô</strong></td>
                            </tr>
                            <tr>
                                <td style=""width:100px"">
                                </td>
                                <td>
                                    <div style=""color: #698096;"">Số tài khoản</div>
                                </td>
                                <td><strong>19131835226016</strong></td>
                            </tr>
                            <tr>
                                <td style=""width:100px"">
                                </td>
                                <td>
                                    <div style=""color: #698096;"">Chủ tài khoản</div>
                                </td>
                                <td><strong>Công ty Cổ phần Thương mại và Dịch vụ Quốc tế Đại Việt</strong></td>
                            </tr>
                            <tr>
                                <td colspan=""4"">
                                    <div style=""border-bottom:1px solid #E3EBF3""></div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan=""4"">
                                    <div><strong>Bạn đã thanh toán xong?</strong></div>
                                    <div style=""color: #698096;margin-bottom: 10px"">
                                        Sau khi xác nhận số tiền thanh toán,<br />chúng tôi sẽ gửi vé điện tử vào email của bạn
                                    </div>
                                    <a href=""{{payLinkDone}}"" class=""btn-default gray full"" style=""text-decoration: none;"">
                                        <strong>Tôi đã thanh toán xong</strong>
                                    </a>
                                </td>
                            </tr>

                        </table>
                    </div>
                </div>
                <div style=""margin-bottom: 15px"">
                    <p><strong>Ghi chú:</strong></p>
                    <ul style=""color: #698096;padding-left: 40px;margin-bottom: 20px;"">
                        <li>Quý khách vui lòng tham khảo chi tiết điều lệ vận chuyển quốc nội tại đây khi tham gia bay</li>
                        <li>Giá đã bao gồm thuế và các loại phí dich vụ khác</li>
                        <li>Điều kiện hoàn hủy và phí hoàn hủy sẽ được tính theo quy định của hãng hàng không và khách sạn</li>
                        <li>Quan trọng: Trường hợp quý khách có yêu cầu xuất hoát đơn đặc biệt, vui lòng liên hệ bộ phận CSKH để được hỗ trợ trong khung thời gian quy định xuất hóa đơn cho phép của Adavigo</li>
                    </ul>

                    <p><strong><em>Lưu ý: Đây là Email tự động, quý khách vui lòng không trả lời Email này</em></strong></p>
                </div>
                <table cellspacing=""0"" cellpadding=""0"" width=""100%"">
                    <tr>
                        <td style=""text-align: center"">
                            <div><img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/phone.png""></div>
                            <div style=""color: #698096;"">Hỗ trợ khách hàng 24/7 Hotline:0936191192</div>
                        </td>
                        <td style=""text-align: center"">
                            <div><img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/car.png""></div>
                            <div style=""color: #698096;"">Ứng dụng tiện lợi, thanh toán dễ dàng</div>
                        </td>
                        <td style=""text-align: center"">
                            <div><img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/plane.png""></div>
                            <div style=""color: #698096;"">Giá tốt sát ngày, Nhiều ưu đãi hấp dẫn</div>
                        </td>
                    </tr>
                </table>
            </div>
        </div>

        <table role=""presentation"" border=""0"" width=""100%"" style=""background: #0159a1;color: #fff;"">
            <tbody>
                <tr>
                    <td style=""padding: 15px;"">
                        <div style=""float: left;margin-bottom: 20px;"">
                            <img width=""80"" src=""https://old.adavigo.com/images/logo/logo-adavigo.png"" alt="""" style=""background: #fff;border-radius: 5px;float: left;"">
                            <span style=""font-weight: bold;
                                        margin: 10px 0 0 10px;
                                        display: inline-block;"">CÔNG TY CỔ PHẦN THƯƠNG MẠI &amp; DỊCH VỤ QUỐC TẾ ĐẠI VIỆT</span>
                        </div>
                        <div style=""float: left;"">
                            <div><b>Trụ sở chính:</b> Tầng 4 Tòa nhà D Khu văn phòng Vinaconex 1, Số 289A Khuất Duy Tiến, phường Trung Hòa, quận Cầu Giấy, Thành phố Hà Nội</div>
                            <div><b>Tổng đài kinh doanh</b>: 0936.191.192</div>
                            <div><b>Tổng đài chăm sóc khách hàng</b>: 0326.333.333</div>
                            <div><b>Tổng đài văn phòng Phú Quốc</b>: 0902.161.162</div>
                            <br>
                            <div><b>VĂN PHÒNG GIAO DỊCH:</b></div>
                            <div><img width=""12"" src=""https://static-image.adavigo.com/uploads/images/email/location.jpg"" style=""margin: 0 4px 0 10px;""><b>Hà Nội:</b> Số 289A Khuất Duy Tiến, Cầu Giấy, Hà Nội</div>
                            <div><img width=""12"" src=""https://static-image.adavigo.com/uploads/images/email/location.jpg"" style=""margin: 0 4px 0 10px;""><b>Phú Quốc CS1:</b> ShopHouse số 89 đường An Phúc, Grandworld Phú Quốc</div>
                            <div><img width=""12"" src=""https://static-image.adavigo.com/uploads/images/email/location.jpg"" style=""margin: 0 4px 0 10px;""><b>Phú Quốc CS2:</b> Số 72 Trần Hưng Đạo, Phường Dương Đông, Thành Phố Phú Quốc</div>
                            <div><img width=""12"" src=""https://static-image.adavigo.com/uploads/images/email/location.jpg"" style=""margin: 0 4px 0 10px;""><b>Hồ Chí Minh:</b>Số 1 Hoàng Việt, Phường 4, Quận Tân Bình, TP. HCM</div>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
      
    </div>
</body>

</html>


";
        public static string HotelBookingB2B = @"
<!doctype html>
<html>

<head>
    <meta content=""width=device-width"">
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <title>Simple Email</title>
    <style>
        * {
            margin: 0;
            padding: 0;
            -webkit-box-sizing: border-box;
            box-sizing: border-box;
        }

        .btn-default {
            display: inline-block;
            color: #fff;
            font-size: 16px;
            font-weight: 500;
            line-height: 40px;
            border-radius: 10px;
            padding: 0 24px;
            text-align: center;
            background: #FF5B00;
            transition: 0.2s all;
            border: 1px solid #FF5B00;
            cursor: pointer;
        }

            .btn-default.gray {
                background: #E3EBF3;
                color: #00264D;
                border: 1px solid #E3EBF3;
            }

            .btn-default.full {
                width: 100%;
            }

        table td {
            padding: 4px 10px;
            vertical-align: top;
        }

        .table-border {
            border-collapse: collapse;
        }

            .table-border th,
            .table-border td {
                border: 1px solid #E3EBF3;
                border-collapse: collapse;
            }
        /* Responsive design */
        .im {
            color: #121111;
        }

        @media only screen and (max-width: 600px) {
            table[class=""container""] {
                width: 100% !important;
            }

            td[class=""header-cell""] {
                padding: 20px 0 20px 0 !important;
            }

            td[class=""body-cell""] {
                padding: 20px 20px 20px 20px !important;
            }
        }
    </style>
</head>

<body style=""margin: 0; padding: 0; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;line-height: 1.4;font-family: Arial;font-size:16px;"">
    <table class=""container"" width=""900"" cellpadding=""0"" cellspacing=""0"" style=""margin: 0 auto;"">
        <tr>
            <td>
                <table cellspacing=""0"" cellpadding=""0"" width=""100%"" style=""background: #F1F5F9;border-top: 3px solid #070BA0;padding:5px 15px;"">
                    <tr>
                        <td><img alt="""" src=""https://static-image.adavigo.com/uploads/images/logo.png""></td>
                        <td style=""text-align: right""><img alt="""" src=""https://static-image.adavigo.com/uploads/images/hotline.png""></td>
                    </tr>
                </table>
                <div style=""padding: 15px 0;"">
                    <table cellspacing=""0"" cellpadding=""0"" width=""100%"">
                        <tr>
                            <td colspan=""4"">
                                Chào quý khách, <strong>{{ClientName}}</strong>
                                <br />
                                <div>
                                    Xin cảm ơn quý khách đã sử dụng dịch vụ của Adavigo
                                </div>

                                <br />
                                <br />
                                Mã đơn hàng: <strong style=""color: #FF5B00;font-size:24px"">{{OrderNo}}</strong>
                                <strong style=""background: #FFEFD7;border-radius: 6px;padding: 4px 8px;color: #D09111;margin-left:2px;"">Đơn hàng đang được nhân viên tiếp nhận xử lý</strong>
                                <br />
                                <br />
                                <div style=""border-bottom:1px solid #E3EBF3;""></div>
                            </td>
                        </tr>
                        <tr>
                            <td style=""color: #698096;"">Khách hàng</td>
                            <td style=""color: #698096;"">Ngày đặt</td>
                            <td style=""color: #698096;"">Số điện thoại</td>
                            <td style=""color: #698096;"">Email</td>
                        </tr>
                        <tr>
                            <td>{{ClientName}}</td>
                            <td>{{CreatedDate}}</td>
                            <td>{{Phone}}</td>
                            <td><a href=""#"" style=""color: #1254FF"">{{Email}}</a></td>
                        </tr>
                        <tr>
                            <td colspan=""4"">
                                <div style=""border-bottom:1px solid #E3EBF3;margin: 0 0 10px 0""></div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <img alt="""" src=""{{ImageThumb}}"" width=""100%"" style=""width:250px;"">
                            </td>
                            <td colspan=""3"">
                                <div>
                                    <strong style=""margin-right:10px"">{{HotelName}}</strong>

                                </div>
                                <div>{{Address}}</div>


                            </td>
                        </tr>
                        <tr>
                            <td colspan=""4"">
                                <div style=""border-bottom:1px solid #E3EBF3;margin: 0 0 10px 0""></div>
                            </td>
                        </tr>
                    </table>

                    <table cellspacing=""0"" cellpadding=""0"" width=""100%"">
                       <tr>
                            <td colspan=""2"">
                                Quý khách cũng có thể dễ dàng tìm hiểu về các quy trình và tiện nghi của chỗ nghỉ tại <a href=""#"" style="" color: #1254FF;"">Đơn hàng của tôi</a>
                                </br>Mọi câu hỏi liên quan đến chỗ nghỉ, vui lòng liên hệ trực tiếp với chỗ nghỉ.
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div style=""background: #E6F7FF;border-radius: 10px;text-align: center;padding: 8px;"">
                                    <strong>Thư điện tử:</strong></br>
                                    <a href=""#"" style=""color: #1254FF;text-decoration: none;"">info@adavigo.com</a>
                                </div>
                            </td>
                            <td>
                                <div style=""background: #E6F7FF;border-radius: 10px;text-align: center;padding: 8px;"">
                                    <strong>Điện thoại:</strong></br>
                                    <a href=""#"" style=""color: #1254FF;text-decoration: none;"">0936.191.192</a>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan=""2"">
                                <div style=""border-bottom:1px solid #E3EBF3;margin: 10px 0 20px 0""></div>
                            </td>
                        </tr>
                    </table>
                    <div>
                        <div style='font-size: 18px; margin-bottom: 15px; margin-top: 15px;'><strong> Thông tin về Đơn đặt phòng </strong></div>
                        {{DataTable}}
                    </div>

                    <div >
                        <div style=""font-size: 18px; margin-bottom: 15px; margin-top: 15px;""><strong>Thông tin hành khách</strong></div>
                        <table class=""table-border""   width=""100%"">
                            <tr style=""background: #8C9FB1;"">
                                <td style=""color: #fff;width: 60px;"">STT</td>
                                <td style=""color: #fff;width: 100px;"">Số phòng</td>
                                <td style=""color: #fff;width: 180px;"">Loại phòng</td>
                                <td style=""color: #fff;"">Tên khách hàng</td>
                                <td style=""color: #fff;"">Ngày sinh</td>
                            </tr>
                            {{hotelGuests}}
                        </table>
                        {{Note}}
                    </div>
                    <div style=""padding: 0 10px;"">
                        <div style=""font-size:18px;margin-bottom:15px;margin-top:15px;""><strong> Chi tiết giá </strong></div>
                        <table class=""table-border""  width=""900"" width=""100%"">
                            <tr>
                                <td colspan=""2"" style=""border: 0;padding: 10px 0;"">
                                    <div><strong>{{TotalRooms}} Phòng x {{TotalDays}} Đêm</strong></div>

                                </td>
                                <td style=""text-align: right;border: 0; vertical-align: bottom;padding: 10px 0;"">
                                    <strong style=""font-size:18px;color: #00A86B;"">{{totalAmount3}} đ</strong>
                                </td>
                            </tr>
                            <tr>
                                <td colspan=""2"" style=""border: 0;padding: 10px 0;"">
                                    <div><strong>Thuế và phí dịch vụ khách sạn</strong></div>

                                </td>
                                <td style=""text-align: right;border: 0; vertical-align: bottom;padding: 10px 0;"">
                                    <strong style=""font-size:18px;color: #00A86B;"">{{totalAmount2}} đ</strong>
                                </td>
                            </tr>
                            <tr>
                                <td colspan=""2"" style=""border: 0;padding: 10px 0;"">
                                    <div><strong>Mã giảm giá :</strong> <strong style=""color: red;"">{{VoucherCode}}</strong></div>

                                </td>
                                <td style=""text-align: right;border: 0; vertical-align: bottom;padding: 10px 0;"">
                                    <strong style=""font-size:18px;color: #00A86B;"">{{AmountVoucher}} đ</strong>
                                </td>
                            </tr>
                            <tr>
                                <td colspan=""2"" style=""border: 0;padding: 10px 0;"">
                                    <div><strong>Phí giao dịch ngân hàng</strong></div>

                                </td>
                                <td style=""text-align: right;border: 0; vertical-align: bottom;padding: 10px 0;"">
                                    <strong style=""font-size:18px;color: #00A86B;"">{{AmountPayment}} đ</strong>
                                </td>
                            </tr>
                            <tr>
                                <td colspan=""2"" style=""border: 0;padding: 10px 0;"">
                                    <div><strong>Tổng tiền</strong></div>

                                </td>
                                <td style=""text-align: right;border: 0; vertical-align: bottom;padding: 10px 0;"">
                                    <strong style=""font-size:18px;color: #00A86B;"">{{totalAmount}} đ</strong>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div style=""width: 100%;;margin-top: 20px;padding: 0 10px;"">
                        <div style=""padding: 25px;background: #F1F5F9 url(images/email/fly2.png) no-repeat right 20px top 20px;border-radius: 20px;margin-bottom: 25px"">
                            <table cellspacing=""0"" cellpadding=""0"" width=""100%"">
                                <tr>
                                    <td colspan=""3"">
                                        <div style=""font-size: 24px;""><strong>Thanh toán</strong></div>
                                        Số tiền cần thanh toán: <strong style=""color:#FF5B00"">{{totalAmount}} đ</strong>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan=""3"" style=""text-align:center"">
                                        <span style=""background: #FFEFD7;
                                    border-radius: 6px;
                                    padding: 5px 8px;
                                    color: #D09111;font-size: 14px;"">
                                            <img alt="""" src=""images/email/warring.png"">&nbsp;
                                            Lưu ý: Vui lòng chuyển đúng đến 3 số cuối
                                        </span>
                                    </td>
                                </tr>
                            </table>
                            <div style=""background: #FFFFFF;border-radius: 20px;padding: 20px 10px"">
                                <table cellspacing=""0"" cellpadding=""0"" style=""width: 100%;color: #00264D;font-size:16px;"">
                                    <tr>
                                        <td style=""width:100px"">
                                            <strong style=""background: #00A86B;border-radius: 66px;padding: 2px 8px;color: #fff;display: block;text-align: center;"">Cách 1</strong>
                                        </td>
                                        <td colspan=""2"">
                                            <strong>Thanh toán VnPay - QR/ Thẻ ATM Nội Địa / Thẻ Visa / Master</strong> </br>
                                            <div style=""color: #698096;margin-bottom: 10px"">Adavigo sẽ thu hộ phí qua cổng thanh toán</div>
                                            <a href=""{{Link}}"" class=""btn-default"" style=""width: 210px;text-decoration: none;color:white;"">Thanh toán</a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style=""width:100px"">
                                            <strong style=""background: #00A86B;border-radius: 66px;padding: 2px 8px;color: #fff;display: block;text-align: center;"">Cách 2</strong>
                                        </td>
                                        <td>
                                            <strong>Chuyển khoản</strong> </br>
                                            <div style=""color: #698096;"">Nội dung chuyển khoản</div>
                                            <div style=""color: #F63B2F;"">Cần ghi rỗ nội dung chuyển khoản</div>
                                        </td>
                                        <td><strong>{{OrderNo}} thanh toan</strong></td>
                                        <th rowspan=""4"">
											<div style=""text-align:center""><img alt="""" style=""max-width:240px;"" src=""{{LinkQR}}""></div>
											<div style=""text-align:center""><strong>Quét mã QR để thanh toán </strong></div>
											<div style=""text-align:center;color: #698096;"">Sử dụng internet banking hoặc ứng dụng hỗ trợ QR code để quét mã</div>
										</th>
                                    </tr>
                                    <tr>
                                        <td style=""width:100px"">
                                        </td>
                                        <td>
                                            <div style=""color: #698096;"">Ngân hàng/chi nhánh</div>
                                        </td>
                                        <td><strong>Ngân Hàng TMCP Kỹ Thương Việt Nam chi nhánh Đông Đô</strong></td>
                                    </tr>
                                    <tr>
                                        <td style=""width:100px"">
                                        </td>
                                        <td>
                                            <div style=""color: #698096;"">Số tài khoản</div>
                                        </td>
                                        <td><strong>19131835226016</strong></td>
                                    </tr>
                                    <tr>
                                        <td style=""width:100px"">
                                        </td>
                                        <td>
                                            <div style=""color: #698096;"">Chủ tài khoản</div>
                                        </td>
                                        <td><strong>Công ty cổ phần & thương mại Đại Việt</strong></td>
                                    </tr>
                                    <tr>
                                        <td colspan=""4"">
                                            <div style=""border-bottom:1px solid #E3EBF3""></div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan=""4"">
                                            <div><strong>Bạn đã thanh toán xong?</strong></div>
                                            <div style=""color: #698096;margin-bottom: 10px"">
                                                Sau khi xác nhận số tiền thanh toán,</br>chúng tôi sẽ gửi vé điện tử vào email của bạn
                                            </div>
                                            <a href=""#"" class=""btn-default gray full"" style=""text-decoration: none;""><strong>Tôi đã thanh toán xong</strong></a>
                                        </td>
                                    </tr>

                                </table>
                            </div>
                        </div>

                        <div style=""margin-bottom: 15px"">
                            <p><strong>Ghi chú:</strong></p>
                            <ul style=""color: #698096;padding-left: 40px;margin-bottom: 20px;"">
                                <li>Quý khách vui lòng tham khảo chi tiết điều lệ vận chuyển quốc nội tại đây khi tham gia bay</li>
                                <li>Giá đã bao gồm thuế và các loại phí dich vụ khác</li>
                                <li>Điều kiện hoàn hủy và phí hoàn hủy sẽ được tính theo quy định của hãng hàng không và khách sạn</li>
                                <li>Quan trọng: Trường hợp quý khách có yêu cầu xuất hoát đơn đặc biệt, vui lòng liên hệ bộ phận CSKH đeer được hỗ trợ trong khung thời gian quy định xuất hóa đơn cho phép của Adavigo</li>
                            </ul>

                            <p><strong><em>Lưu ý: Đây là Email tự động, quý khách vui lòng không trả lời Email này</em></strong></p>
                        </div>
                        <table cellspacing=""0"" cellpadding=""0"" width=""100%"">
                            <tr>
                                <td style=""text-align: center"">
                                    <div><img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/phone.png""></div>
                                    <div style=""color: #698096;"">Hỗ trợ khách hàng 24/7 0936.191.192</div>
                                </td>
                                <td style=""text-align: center"">
                                    <div><img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/car.png""></div>
                                    <div style=""color: #698096;"">Ứng dụng tiện lợi, thanh toán dễ dàng</div>
                                </td>
                                <td style=""text-align: center"">
                                    <div><img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/plane.png""></div>
                                    <div style=""color: #698096;"">Giá tốt sát ngày, Nhiều ưu đãi hấp dẫn</div>
                                </td>
                            </tr>
                        </table>

                    </div>
                </div>

                <div style=""padding: 30px;color:#fff;background: #070BA0;font-size:14px"">
                    <div style=""padding: 30px;color:#fff;background: #070BA0;font-size:14px"">
                        <strong>CÔNG TY CỔ PHẦN THƯƠNG MẠI & DỊCH VỤ QUỐC TẾ ĐẠI VIỆT</strong>
                        <br />
                        <br />
                        Trụ sở chính tại Hà Nội:<br />

                        Địa chỉ: Tầng 4 Tòa nhà D Khu văn phòng Vinaconex 1, Số 289A Khuất Duy Tiến, phường Trung Hòa, quận Cầu Giấy, Thành phố Hà Nội<br />

                        Văn phòng đại diện tại Hà Nội:<br />

                        Địa chỉ: Vinaconex 1, 289A, Khuất Duy Tiến, P. Trung Hoà, Q. Cầu Giấy, TP. Hà Nội<br />

                        Văn phòng đại diện tại Phú Quốc:<br />

                        Địa chỉ: Số 72 Trần Hưng Đạo, Phường Dương Đông, Thành Phố Phú Quốc.<br />

                        Văn phòng đại diện tại Hồ Chí Minh:<br />

                        Địa chỉ: Số 1 Hoàng Việt, Phường 4, Quận Tân Bình, TP. HCM<br />
                    </div>
                </div>
            </td>
        </tr>
    </table>
</body>

</html>
";
        public static string MailTemplateB2B = @"
<!doctype html>
<html>

<head>
    <meta content=""width=device-width"">
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <title>Email Order Notification</title>
    <style>
        * {
            margin: 0;
            padding: 0;
            -webkit-box-sizing: border-box;
            box-sizing: border-box;
        }

        .btn-default {
            display: inline-block;
            color: #fff;
            font-size: 16px;
            font-weight: 500;
            line-height: 40px;
            border-radius: 10px;
            padding: 0 24px;
            text-align: center;
            background: #FF5B00;
            transition: 0.2s all;
            border: 1px solid #FF5B00;
            cursor: pointer;
        }

            .btn-default.gray {
                background: #E3EBF3;
                color: #00264D;
                border: 1px solid #E3EBF3;
            }

            .btn-default.full {
                width: 100%;
            }

        table td {
            padding: 4px 10px;
            vertical-align: top;
        }

        .table-border {
            border-collapse: collapse;
        }

            .table-border th,
            .table-border td {
                border: 1px solid #E3EBF3;
                border-collapse: collapse;
            }
        /* Responsive design */

        @media only screen and (max-width: 600px) {
            table[class=""container""] {
                width: 100% !important;
            }

            td[class=""header-cell""] {
                padding: 20px 0 20px 0 !important;
            }

            td[class=""body-cell""] {
                padding: 20px 20px 20px 20px !important;
            }
        }
    </style>
</head>

<body style=""margin: 0; padding: 0; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;line-height: 1.4;font-family: Arial;font-size:16px;"">
    <table class=""container"" width=""700"" cellpadding=""0"" cellspacing=""0"" style=""margin: 0 auto;"">
        <tr>
            <td>
                <table cellspacing=""0"" cellpadding=""0"" width=""100%"" style=""background: #F1F5F9;border-top: 3px solid #070BA0;padding:5px 0px;"">
                    <tr>
                        <td><img alt="""" src=""images/email/logo.png""></td>
                        <td style=""text-align: right""><img alt="""" src=""images/email/hotline.png""></td>
                    </tr>
                </table>
                <div style=""padding: 15px 0;"">
                    <table cellspacing=""0"" cellpadding=""0"" width=""100%"">
                        <tr>
                            <td colspan=""4"">
                                Chào quý khách, <strong>{{customerName}}</strong> <br />
                                Xin cảm ơn quý khách đã sử dụng dịch vụ của Adavigo
                                <br />
                                <br />
                                Mã đơn hàng: <strong style=""color: #FF5B00;font-size:24px"">{{orderNo}}</strong>
                                <strong style=""background: #FFEFD7;border-radius: 6px;padding: 4px 8px;color: #D09111;margin-left:10px;"">
                                    {{keepTicketTime}}
                                </strong>
                                <strong style=""border-radius: 6px;padding: 4px 8px;color: red;margin-left:10px; font-size:14px !important"">
                                    {{keepTicketTimeText}}
                                </strong>
                                <br />
                                <br />
                                <div style=""border-bottom:1px solid #E3EBF3;""></div>
                            </td>
                        </tr>
                        <tr style="" white-space: nowrap;"">
                            <td style=""color: #698096;"">Ngày đặt</td>
                            <td style=""color: #698096;"">Khách hàng</td>
                            <td style=""color: #698096;"">Số điện thoại</td>
                            <td style=""color: #698096;"">Email</td>
                        </tr>
                        <tr style="" white-space: nowrap;"">
                            <td>{{orderDate}}</td>
                            <td>{{customerName}}</td>
                            <td>{{phone}}</td>
                            <td><a style=""color: #1254FF"">{{email}}</a></td>
                        </tr>
                        <tr>
                            <td colspan=""4"">
                                <div style=""border-bottom:1px solid #E3EBF3;margin: 0 0 10px 0""></div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <img alt="""" src="" {{hotelImage}}"" width=""100"" height=""100"">

                            </td>
                            <td colspan=""3"">
                                <div>
                                    <strong style=""margin-right:10px"">{{hotelName}}</strong>
                                    <img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/star.png"">
                                    <img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/star.png"">
                                    <img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/star.png"">
                                    <img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/star.png"">
                                    <img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/star.png"">
                                </div>
                                <div>{{hotelAddress}}</div><!--25 Hoàng Liên, Sapa, Việt Nam-->
                                <!--<a href=""#"" style=""color: #1254FF;text-decoration: none;"">Chỉ đường > </a>-->
                                <div>Mã đặt chỗ: <strong style=""color: #FF5B00;font-size:24px"">{{hotelBookingGo}}</strong></div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan=""4"">
                                <div style=""border-bottom:1px solid #E3EBF3;margin: 0 0 10px 0""></div>
                            </td>
                        </tr>
                    </table>

                    <table cellspacing=""0"" cellpadding=""0"" width=""100%"">
                        <tr>
                            <td>
                                <div>
                                    <div style=""font-size: 18px; font-weight: bold;"">Nhận phòng</div>
                                    <div>{{receiveRoom}}</div> <!--Thứ 5, ngày 27 tháng 10 năm 2022-->
                                    (Sau {{checkinTime}})
                                </div>
                            </td>
                            <td style=""border-left: 1px solid #E3EBF3;"">
                                <div style=""text-align: right"">
                                    <div style=""font-size: 18px; font-weight: bold;"">Trả phòng</div>
                                    <div>{{returnRoom}}</div> <!--Thứ 5, ngày 27 tháng 10 năm 2022-->
                                    (Trước {{checkoutTime}})
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan=""2""></td>
                        </tr>
                        <!--<tr>
                <td colspan=""2"">
                    Quý khách cũng có thể dễ dàng tìm hiểu về các quy trình và tiện nghi của chỗ nghỉ tại <a href=""{{urlMyOrder}}"" style="" color: #1254FF;"">Đơn hàng của tôi</a>
                    <br />Mọi câu hỏi liên quan đến chỗ nghỉ, vui lòng liên hệ trực tiếp với chỗ nghỉ.
                </td>
            </tr>-->
                        <tr>
                            <td>
                                <div style=""background: #E6F7FF;border-radius: 10px;text-align: center;padding: 8px;"">
                                    <strong>Thư điện tử:</strong><br />
                                    <!--<a href=""#"" style=""color: #1254FF;text-decoration: none;"">{{hotelEmail}}</a>--> <!--dhomesapaboooking@gmail.com-->
                                    <a href=""#"" style=""color: #1254FF;text-decoration: none;"">cskh@adavigo.com</a> <!--dhomesapaboooking@gmail.com-->
                                </div>
                            </td>
                            <td>
                                <div style=""background: #E6F7FF;border-radius: 10px;text-align: center;padding: 8px;"">
                                    <strong>Điện thoại:</strong><br />
                                    <!--<a href=""#"" style=""color: #1254FF;text-decoration: none;"">{{hotelPhone}}</a>--> <!--84-0869626750-->
                                    <a href=""#"" style=""color: #1254FF;text-decoration: none;"">0936.191.192</a> <!--84-0869626750-->
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan=""2"">
                                <div style=""border-bottom:1px solid #E3EBF3;margin: 10px 0 20px 0""></div>
                            </td>
                        </tr>
                    </table>

                    <div style=""padding: 0 10px;"">
                        <div style=""font-size: 18px;margin-bottom: 15px;""><strong>Thông tin về Đơn đặt phòng</strong></div>
                        <table class=""table-border"" width=""100%"">
                            <tr style=""background: #8C9FB1;"">
                                <td style=""color: #fff;width: 180px;"">Loại phòng</td>
                                <td style=""color: #fff;"">Số người</td>
                                <td style=""color: #fff;"">Dịch vụ phòng/gói</td>
                            </tr>
                            {{hotelRooms}}
                        </table>
                    </div>

                    <div style=""padding: 0 10px; margin-top: 20px"">
                        <div style=""font-size: 18px;margin-bottom: 15px;""><strong>Thông tin hành khách</strong></div>
                        <table class=""table-border"" width=""100%"">
                            <tr>
                                <td>STT</td>
                                <td>Số phòng</td>
                                <td>Loại phòng</td>
                                <td>Tên khách hàng</td>
                                <td>Ngày sinh</td>
                            </tr>
                            {{hotelGuests}}
                            <tr>
                                <td colspan=""4"" style=""border: 0;padding: 10px 0; margin-top: 25px"">
                                    <div><strong>Thanh toán</strong></div>
                                    <div style=""color: #698096;"">Đã bao gồm VAT</div>
                                </td>
                                <td style=""text-align: right;border: 0; vertical-align: bottom;padding: 10px 0;"">
                                    <strong style=""font-size:18px;color: #00A86B;"">{{amount}} đ</strong>
                                </td>
                            </tr>
                        </table>
                    </div>

                    <div style=""width: 100%;;margin-top: 20px;padding: 0 10px;"">
                        <div style=""padding: 25px;background: #F1F5F9 url(images/email/fly2.png) no-repeat right 20px top 20px;border-radius: 20px;margin-bottom: 25px"">
                            <table cellspacing=""0"" cellpadding=""0"" width=""100%"">
                                <tr>
                                    <td colspan=""3"">
                                        <div style=""font-size: 24px;""><strong>Thanh toán</strong></div>
                                        Số tiền cần thanh toán: <strong style=""color:#FF5B00"">{{amount}} đ</strong>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan=""3"" style=""text-align:center"">
                                        <span style=""background: #FFEFD7;border-radius: 6px;padding: 5px 8px;color: #D09111;font-size: 14px;"">
                                            <img alt="""" src=""images/email/warring.png"">&nbsp;
                                            Lưu ý: Vui lòng chuyển đúng đến 3 số cuối
                                        </span>
                                    </td>
                                </tr>
                            </table>
                            <div style=""background: #FFFFFF;border-radius: 20px;padding: 20px"">
                                <table cellspacing=""0"" cellpadding=""0"" style=""width: 100%;color: #00264D;font-size:16px;"">
                                    <tr>
                                        <td style=""width:100px"">
                                            <strong style=""background: #00A86B;border-radius: 66px;padding: 2px 8px;color: #fff;display: block;text-align: center;"">Cách 1</strong>
                                        </td>
                                        <td colspan=""2"" style="""">
                                            <strong>Thanh toán VnPay - QR/ Thẻ ATM Nội Địa / Thẻ Visa / Master</strong> <br />
                                            <div style=""color: #698096;margin-bottom: 10px"">Adavigo sẽ thu hộ phí qua cổng thanh toán</div>
                                            <a href=""{{payLink}}"" class=""btn-default"" style=""width: 210px; text-decoration: none; color: #fff !important;"">Thanh toán</a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style=""width:100px"">
                                            <strong style=""background: #00A86B;border-radius: 66px;padding: 2px 8px;color: #fff;display: block;text-align: center;"">Cách 2</strong>
                                        </td>
                                        <td>
                                            <strong>Nội dung chuyển khoản ghi rõ:</strong> <br />
                                        </td>
                                        <td>
                                            <strong>{{orderNo}} thanh toan</strong><br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style=""width:100px"">
                                        </td>
                                        <td>
                                            <div style=""color: #698096;"">Ngân hàng/chi nhánh</div>
                                        </td>
                                        <td><strong>Ngân Hàng TMCP Kỹ Thương Việt Nam chi nhánh Đông Đô</strong></td>
                                    </tr>
                                    <tr>
                                        <td style=""width:100px"">
                                        </td>
                                        <td>
                                            <div style=""color: #698096;"">Số tài khoản</div>
                                        </td>
                                        <td><strong>19131835226016</strong></td>
                                    </tr>
                                    <tr>
                                        <td style=""width:100px"">
                                        </td>
                                        <td>
                                            <div style=""color: #698096;"">Chủ tài khoản</div>
                                        </td>
                                        <td><strong>Công ty Cổ phần Thương mại và Dịch vụ Quốc tế Đại Việt</strong></td>
                                    </tr>
                                    <tr>
                                        <td colspan=""3"">
                                            <div style=""border-bottom:1px solid #E3EBF3""></div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan=""3"">
                                            <div><strong>Bạn đã thanh toán xong?</strong></div>
                                            <div style=""color: #698096;margin-bottom: 10px"">
                                                Sau khi xác nhận số tiền thanh toán,<br />chúng tôi sẽ gửi vé điện tử vào email của bạn
                                            </div>
                                            <a href=""{{payLinkDone}}"" class=""btn-default gray full"" style=""text-decoration: none;"">
                                                <strong>Tôi đã thanh toán xong</strong>
                                            </a>
                                        </td>
                                    </tr>

                                </table>
                            </div>
                        </div>

                        <div style=""margin-bottom: 15px"">
                            <p><strong>Ghi chú:</strong></p>
                            <ul style=""color: #698096;padding-left: 40px;margin-bottom: 20px;"">
                                <li>Quý khách vui lòng tham khảo chi tiết điều lệ vận chuyển quốc nội tại đây khi tham gia bay</li>
                                <li>Giá đã bao gồm thuế và các loại phí dich vụ khác</li>
                                <li>Điều kiện hoàn hủy và phí hoàn hủy sẽ được tính theo quy định của hãng hàng không và khách sạn</li>
                                <li>Quan trọng: Trường hợp quý khách có yêu cầu xuất hoát đơn đặc biệt, vui lòng liên hệ bộ phận CSKH để được hỗ trợ trong khung thời gian quy định xuất hóa đơn cho phép của Adavigo</li>
                            </ul>

                            <p><strong><em>Lưu ý: Đây là Email tự động, quý khách vui lòng không trả lời Email này</em></strong></p>
                        </div>
                        <table cellspacing=""0"" cellpadding=""0"" width=""100%"">
                            <tr>
                                <td style=""text-align: center"">
                                    <div><img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/phone.png""></div>
                                    <div style=""color: #698096;"">Hỗ trợ khách hàng 24/7 Hotline:0936191192</div>
                                </td>
                                <td style=""text-align: center"">
                                    <div><img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/car.png""></div>
                                    <div style=""color: #698096;"">Ứng dụng tiện lợi, thanh toán dễ dàng</div>
                                </td>
                                <td style=""text-align: center"">
                                    <div><img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/plane.png""></div>
                                    <div style=""color: #698096;"">Giá tốt sát ngày, Nhiều ưu đãi hấp dẫn</div>
                                </td>
                            </tr>
                        </table>

                    </div>
                </div>

                <table role=""presentation"" border=""0"" width=""100%"" style=""background: #0159a1;color: #fff;"">
                    <tbody>
                        <tr>
                            <td style=""padding: 15px;"">
                                <div style=""float: left;margin-bottom: 20px;"">
                                    <img width=""80"" src=""https://old.adavigo.com/images/logo/logo-adavigo.png"" alt="""" style=""background: #fff;border-radius: 5px;float: left;"">
                                    <span style=""font-weight: bold;
                                        margin: 10px 0 0 10px;
                                        display: inline-block;"">CÔNG TY CỔ PHẦN THƯƠNG MẠI &amp; DỊCH VỤ QUỐC TẾ ĐẠI VIỆT</span>
                                </div>
                                <div style=""float: left;"">
                                    <div><b>Trụ sở chính:</b> Tầng 4 Tòa nhà D Khu văn phòng Vinaconex 1, Số 289A Khuất Duy Tiến, phường Trung Hòa, quận Cầu Giấy, Thành phố Hà Nội</div>
                                    <div><b>Tổng đài kinh doanh</b>: 0936.191.192</div>
                                    <div><b>Tổng đài chăm sóc khách hàng</b>: 0326.333.333</div>
                                    <div><b>Tổng đài văn phòng Phú Quốc</b>: 0902.161.162</div>
                                    <br>
                                    <div><b>VĂN PHÒNG GIAO DỊCH:</b></div>
                                    <div><img width=""12"" src=""https://static-image.adavigo.com/uploads/images/email/location.jpg"" style=""margin: 0 4px 0 10px;""><b>Hà Nội:</b> Số 289A Khuất Duy Tiến, Cầu Giấy, Hà Nội</div>
                                    <div><img width=""12"" src=""https://static-image.adavigo.com/uploads/images/email/location.jpg"" style=""margin: 0 4px 0 10px;""><b>Phú Quốc CS1:</b> ShopHouse số 89 đường An Phúc, Grandworld Phú Quốc</div>
                                    <div><img width=""12"" src=""https://static-image.adavigo.com/uploads/images/email/location.jpg"" style=""margin: 0 4px 0 10px;""><b>Phú Quốc CS2:</b> Số 72 Trần Hưng Đạo, Phường Dương Đông, Thành Phố Phú Quốc</div>
                                    <div><img width=""12"" src=""https://static-image.adavigo.com/uploads/images/email/location.jpg"" style=""margin: 0 4px 0 10px;""><b>Hồ Chí Minh:</b> Số 1 Hoàng Việt, Phường 4, Quận Tân Bình, TP. HCM</div>
                                </div>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
</body>

</html>

";
        public static string MailTemplateVinWonder = @"
<!doctype html>
<html>

<head>
    <meta content=""width=device-width"">
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <title>Email Order Notification</title>
    <style>
     /*   * {
            margin: 0;
            padding: 0;
            -webkit-box-sizing: border-box;
            box-sizing: border-box;
        }*/

        .btn-default {
            display: inline-block;
            color: #fff;
            font-size: 16px;
            font-weight: 500;
            line-height: 40px;
            border-radius: 10px;
            padding: 0 24px;
            text-align: center;
            background: #FF5B00;
            transition: 0.2s all;
            border: 1px solid #FF5B00;
            cursor: pointer;
        }

            .btn-default.gray {
                background: #E3EBF3;
                color: #00264D;
                border: 1px solid #E3EBF3;
            }

            .btn-default.full {
                width: 92%;
            }

        table td {
            padding: 4px 10px;
            vertical-align: top;
        }

        .table-border {
            border-collapse: collapse;
        }

            .table-border th,
            .table-border td {
                border: 1px solid #E3EBF3;
                border-collapse: collapse;
            }
        /* Responsive design */

        @media only screen and (max-width: 600px) {
            table[class=""container""] {
                width: 100% !important;
            }

            td[class=""header-cell""] {
                padding: 20px 0 20px 0 !important;
            }

            td[class=""body-cell""] {
                padding: 20px 20px 20px 20px !important;
            }
        }
    </style>
</head>

<body style=""margin: 0; padding: 0; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;line-height: 1.4;font-family: Arial;font-size:16px;"">
    <table class=""container"" width=""700"" cellpadding=""0"" cellspacing=""0"" style=""margin: 0 auto;"">
        <tr>
            <td>
                <table cellspacing=""0"" cellpadding=""0"" width=""100%"" style=""background: #F1F5F9;border-top: 3px solid #070BA0;padding:5px 0px;"">
                    <tr>
                        <td><img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/logo.png""></td>
                        <td style=""text-align: right""><img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/hotline.png""></td>
                    </tr>
                </table>
                <div style=""padding: 15px 0;"">
                    <table cellspacing=""0"" cellpadding=""0"" width=""100%"">
                        <tr>
                            <td colspan=""4"">
                                Chào quý khách, <strong>{{customerName}}</strong> <br />
                                Xin cảm ơn quý khách đã sử dụng dịch vụ của Adavigo
                                <br />
                                <br />
                                Mã đơn hàng: <strong style=""color: #FF5B00;font-size:24px"">{{orderNo}}</strong>
                                <strong style=""background: #FFEFD7;border-radius: 6px;padding: 4px 8px;color: #D09111;margin-left:10px;"">
                                    {{keepTicketTime}}
                                </strong>
                                <strong style=""border-radius: 6px;padding: 4px 8px;color: red;margin-left:10px; font-size:14px !important"">
                                    {{keepTicketTimeText}}
                                </strong>
                                <br />
                                <br />
                                <div style=""border-bottom:1px solid #E3EBF3;""></div>
                            </td>
                        </tr>
                        <tr style="" white-space: nowrap;"">
                            <td style=""color: #698096;"">Ngày đặt</td>
                            <td style=""color: #698096;"">Khách hàng</td>
                            <td style=""color: #698096;"">Số điện thoại</td>
                            <td style=""color: #698096;"">Email</td>
                        </tr>
                        <tr style="" white-space: nowrap;"">
                            <td>{{orderDate}}</td>
                            <td>{{customerName}}</td>
                            <td>{{phone}}</td>
                            <td><a style=""color: #1254FF"">{{email}}</a></td>
                        </tr>
                        <tr>
                            <td colspan=""4"">
                                <div style=""border-bottom:1px solid #E3EBF3;margin: 0 0 10px 0""></div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan=""4"">
                                <div style=""border-bottom:1px solid #E3EBF3;margin: 0 0 10px 0""></div>
                            </td>
                        </tr>
                    </table>

                    <div style=""padding: 0 10px;"">
                        <div style=""font-size: 18px;margin-bottom: 15px;""><strong>Thông tin vé</strong></div>
                        <table class=""table-border"" width=""100%"">
                            <tr style=""background: #8C9FB1;"">
                                <td style=""color: #fff;width: 180px;"">Thông tin vé</td>
                                <td style=""color: #fff;"">Đơn vị</td>
                                <td style=""color: #fff;"">Ngày sử dụng</td>
                            </tr>
                            {{vinWonderTickets}}
                        </table>
                    </div>

                    <div style=""padding: 0 10px; margin-top: 20px"">
                        <table class=""table-border"" width=""100%"">
                            <tr>
                                <td colspan=""4"" style=""border: 0;padding: 10px 0; margin-top: 25px"">
                                    <div><strong>Thanh toán</strong></div>
                                    <div style=""color: #698096;"">Đã bao gồm thuế, phí, VAT</div>
                                </td>
                                <td style=""text-align: right;border: 0; vertical-align: bottom;padding: 10px 0;"">
                                    <strong style=""font-size:18px;color: #00A86B;"">{{amount}} đ</strong>
                                </td>
                            </tr>
                        </table>
                    </div>

                    <div style=""width: 100%;;margin-top: 20px;padding: 0 10px;"">
                        <div style=""padding: 25px;background: #F1F5F9 url(images/email/fly2.png) no-repeat right 20px top 20px;border-radius: 20px;margin-bottom: 25px"">
                            <table cellspacing=""0"" cellpadding=""0"" width=""100%"">
                                <tr>
                                    <td colspan=""3"">
                                        <div style=""font-size: 24px;""><strong>Hướng dẫn thanh toán</strong></div>
                                        Số tiền cần thanh toán: <strong style=""color:#FF5B00"">{{amount}} đ</strong>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan=""3"" style=""text-align:center"">
                                        <span style=""background: #FFEFD7;border-radius: 6px;padding: 5px 8px;color: #D09111;font-size: 14px;"">
                                            <img alt="""" src=""images/email/warring.png"">&nbsp;
                                            Lưu ý: Vui lòng chuyển đúng đến 3 số cuối
                                        </span>
                                    </td>
                                </tr>
                            </table>
                            <div style=""background: #FFFFFF;border-radius: 20px;padding: 20px"">
                                <table cellspacing=""0"" cellpadding=""0"" style=""width: 100%;color: #00264D;font-size:16px;"">
                                    <tr>
                                        <td style=""width:100px"">
                                            <strong style=""background: #00A86B;border-radius: 66px;padding: 2px 8px;color: #fff;display: block;text-align: center;"">Cách 1</strong>
                                        </td>
                                        <td colspan=""2"" style="""">
                                            <strong>Thanh toán VnPay - QR/ Thẻ ATM Nội Địa / Thẻ Visa / Master</strong> <br />
                                            <div style=""color: #698096;margin-bottom: 10px"">Adavigo sẽ thu hộ phí qua cổng thanh toán</div>
                                            <a href=""{{payLink}}"" class=""btn-default"" style=""width: 210px; text-decoration: none; color: #fff !important;"">Thanh toán</a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style=""width:100px"">
                                            <strong style=""background: #00A86B;border-radius: 66px;padding: 2px 8px;color: #fff;display: block;text-align: center;"">Cách 2</strong>
                                        </td>
                                        <td>
                                            <strong>Nội dung chuyển khoản ghi rõ:</strong> <br />
                                        </td>
                                        <td>
                                            <strong>{{orderNo}} thanh toan</strong><br />
                                        </td>
										<th rowspan=""4"">
											<div style=""text-align:center""><img alt="""" style=""max-width:202px;"" src=""{{LinkQR}}""></div>
											<div style=""text-align:center""><strong>Quét mã QR để thanh toán </strong></div>
											<div style=""text-align:center;color: #698096;"">Sử dụng internet banking hoặc ứng dụng hỗ trợ QR code để quét mã</div>		
										</th>
                                    </tr>
                                    <tr>
                                        <td style=""width:100px"">
                                        </td>
                                        <td>
                                            <div style=""color: #698096;"">Ngân hàng/chi nhánh</div>
                                        </td>
                                        <td><strong>Ngân Hàng TMCP Kỹ Thương Việt Nam chi nhánh Đông Đô</strong></td>
                                    </tr>
                                    <tr>
                                        <td style=""width:100px"">
                                        </td>
                                        <td>
                                            <div style=""color: #698096;"">Số tài khoản</div>
                                        </td>
                                        <td><strong>19131835226016</strong></td>
                                    </tr>
                                    <tr>
                                        <td style=""width:100px"">
                                        </td>
                                        <td>
                                            <div style=""color: #698096;"">Chủ tài khoản</div>
                                        </td>
                                        <td><strong>Công ty Cổ phần Thương mại và Dịch vụ Quốc tế Đại Việt</strong></td>
                                    </tr>
                                    <tr>
                                        <td colspan=""4"">
                                            <div style=""border-bottom:1px solid #E3EBF3""></div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan=""4"">
                                            <div><strong>Bạn đã thanh toán xong?</strong></div>
                                            <div style=""color: #698096;margin-bottom: 10px"">
                                                Sau khi xác nhận số tiền thanh toán,<br />chúng tôi sẽ gửi vé điện tử vào email của bạn
                                            </div>
                                            <a href=""{{payLinkDone}}"" class=""btn-default gray full"" style=""text-decoration: none;"">
                                                <strong>Tôi đã thanh toán xong</strong>
                                            </a>
                                        </td>
                                    </tr>

                                </table>
                            </div>
                        </div>

                        <div style=""margin-bottom: 15px"">
                            <p><strong>Ghi chú:</strong></p>
                            <ul style=""color: #698096;padding-left: 40px;margin-bottom: 20px;"">
                                <li>Quý khách vui lòng tham khảo chi tiết điều lệ vận chuyển quốc nội tại đây khi tham gia bay</li>
                                <li>Giá đã bao gồm thuế và các loại phí dich vụ khác</li>
                                <li>Điều kiện hoàn hủy và phí hoàn hủy sẽ được tính theo quy định của hãng hàng không và khách sạn</li>
                                <li>Quan trọng: Trường hợp quý khách có yêu cầu xuất hoát đơn đặc biệt, vui lòng liên hệ bộ phận CSKH để được hỗ trợ trong khung thời gian quy định xuất hóa đơn cho phép của Adavigo</li>
                            </ul>

                            <p><strong><em>Lưu ý: Đây là Email tự động, quý khách vui lòng không trả lời Email này</em></strong></p>
                        </div>
                        <table cellspacing=""0"" cellpadding=""0"" width=""100%"">
                            <tr>
                                <td style=""text-align: center"">
                                    <div><img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/phone.png""></div>
                                    <div style=""color: #698096;"">Hỗ trợ khách hàng 24/7 Hotline:0936191192</div>
                                </td>
                                <td style=""text-align: center"">
                                    <div><img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/car.png""></div>
                                    <div style=""color: #698096;"">Ứng dụng tiện lợi, thanh toán dễ dàng</div>
                                </td>
                                <td style=""text-align: center"">
                                    <div><img alt="""" src=""https://static-image.adavigo.com/uploads/images/email/plane.png""></div>
                                    <div style=""color: #698096;"">Giá tốt sát ngày, Nhiều ưu đãi hấp dẫn</div>
                                </td>
                            </tr>
                        </table>

                    </div>
                </div>

                <table role=""presentation"" border=""0"" width=""100%"" style=""background: #0159a1;color: #fff;"">
                    <tbody>
                        <tr>
                            <td style=""padding: 15px;"">
                                <div style=""float: left;margin-bottom: 20px;"">
                                    <img width=""80"" src=""https://old.adavigo.com/images/logo/logo-adavigo.png"" alt="""" style=""background: #fff;border-radius: 5px;float: left;"">
                                    <span style=""font-weight: bold;
                                        margin: 10px 0 0 10px;
                                        display: inline-block;"">CÔNG TY CỔ PHẦN THƯƠNG MẠI &amp; DỊCH VỤ QUỐC TẾ ĐẠI VIỆT</span>
                                </div>
                                <div style=""float: left;"">
                                    <div><b>Trụ sở chính:</b> Tầng 4 Tòa nhà D Khu văn phòng Vinaconex 1, Số 289A Khuất Duy Tiến, phường Trung Hòa, quận Cầu Giấy, Thành phố Hà Nội</div>
                                    <div><b>Tổng đài kinh doanh</b>: 0936.191.192</div>
                                    <div><b>Tổng đài chăm sóc khách hàng</b>: 0326.333.333</div>
                                    <div><b>Tổng đài văn phòng Phú Quốc</b>: 0902.161.162</div>
                                    <br>
                                    <div><b>VĂN PHÒNG GIAO DỊCH:</b></div>
                                    <div><img width=""12"" src=""https://static-image.adavigo.com/uploads/images/email/location.jpg"" style=""margin: 0 4px 0 10px;""><b>Hà Nội:</b> Số 289A Khuất Duy Tiến, Cầu Giấy, Hà Nội</div>
                                    <div><img width=""12"" src=""https://static-image.adavigo.com/uploads/images/email/location.jpg"" style=""margin: 0 4px 0 10px;""><b>Phú Quốc CS1:</b> ShopHouse số 89 đường An Phúc, Grandworld Phú Quốc</div>
                                    <div><img width=""12"" src=""https://static-image.adavigo.com/uploads/images/email/location.jpg"" style=""margin: 0 4px 0 10px;""><b>Phú Quốc CS2:</b> Số 72 Trần Hưng Đạo, Phường Dương Đông, Thành Phố Phú Quốc</div>
                                    <div><img width=""12"" src=""https://static-image.adavigo.com/uploads/images/email/location.jpg"" style=""margin: 0 4px 0 10px;""><b>Hồ Chí Minh:</b> Số 1 Hoàng Việt, Phường 4, Quận Tân Bình, TP. HCM</div>
                                </div>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
</body>

</html>

";
    }
}

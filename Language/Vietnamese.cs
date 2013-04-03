using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Language
{
    public class Vietnamese
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public Vietnamese()
        {
            /* Caption */
            dictionary.Add("CaptionDelete", "Xóa");
            dictionary.Add("CaptionUnderConstruction", "Đang xây dựng");
            dictionary.Add("CaptionError", "Lỗi");

            /* Message */
            dictionary.Add("MessageDelete", "Bạn có chắc muốn xóa?");
            dictionary.Add("MessageDeleteError", "Xóa thất bại! Vui lòng thử lại");
            dictionary.Add("MessageError", "Có lỗi xảy ra");
            dictionary.Add("MessageUnderConstruction", "Đang xây dựng !!!");
            dictionary.Add("MessageDeleteUnable", "Không thể xóa");

            /* Application */
            dictionary.Add("Deposit", "Gửi vào");
            dictionary.Add("Withdraw", "Rút ra");
            dictionary.Add("Lend", "Cho mượn");
            dictionary.Add("Borrow", "Mượn");
            dictionary.Add("Day", "Ngày");
            dictionary.Add("Month", "Tháng");
            dictionary.Add("Year", "Năm");
            dictionary.Add("About", "Giới thiệu");
            dictionary.Add("Submit", "Xác nhận");
            dictionary.Add("Reason", "Lý do");
            dictionary.Add("Present", "Hiện tại");
            dictionary.Add("Date", "Ngày giờ");
            dictionary.Add("File", "Tập tin");
            dictionary.Add("Exit", "Thoát");
            dictionary.Add("Update", "Cập nhật");
            dictionary.Add("Amount", "Sô tiền");
            dictionary.Add("ClosingAmount", "Đầu kỳ");
            dictionary.Add("OpeningAmount", "Cuối kỳ");
            dictionary.Add("Action", "Thao tác");
            dictionary.Add("Language", "Ngôn ngữ");
            dictionary.Add("Remove", "Xóa");
            dictionary.Add("Report", "Báo cáo");
            dictionary.Add("Author", "Tác giả");
            dictionary.Add("Email", "Email");
        }

        public string GetString(string p_Key)
        {
            if (dictionary.ContainsKey(p_Key))
            {
                return dictionary.Single(ob => ob.Key == p_Key).Value;
            }
            else
            {
                throw new NullReferenceException("Key " + p_Key + " isn't exists");
            }
        }
    }
}

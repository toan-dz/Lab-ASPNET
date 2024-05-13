using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeXuanToan_Lab_5_2.Models
{
    interface ICustomerRepository
    {
        //khai báo phương thức lấy danh sách khách hàng
        IList<LxtCustomer> GetCustomers();
        //khai báo phương thức lấy khách hàng
        LxtCustomer GetCustomer(string customerId);
        //khai báo phương thức thêm khách hàng
        void AddCustomer(LxtCustomer cus);
        //khai báo phương thức cập nhật khách hàng
        void UpdateCustomer(LxtCustomer cus);
        //khai báo phương thức tìm kiếm khách hàng
        IList<LxtCustomer> SearchCustomer(string name);
        //khai báo phương thức xóa khách hàng
        void DeleteCustomer(LxtCustomer cus);
    }
}

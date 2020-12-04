﻿using MISA.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Interfaces
{
    public interface ICustomerService: IBaseService<Customer>
    {
        /// <summary>
        /// Lấy dữ liệu phân trang
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns>Danh sách khách hàng được phân trang phù hợp</returns>
        /// CreatedBy HNANH (27/11/2020)
        IEnumerable<Customer> GetCustomerPaging(int limit, int offset);

        /// <summary>
        /// Lấy danh sách khách hàng qua mã nhóm khách hàng
        /// </summary>
        /// <param name="customerGroupId">Id nhóm khách hàng</param>
        /// <returns>Danh sách khách hàng</returns>
        /// CreatedBy HNANH (27/11/2020)
        IEnumerable<Customer> GetCustomersByGroup(Guid customerGroupId);

    }
}
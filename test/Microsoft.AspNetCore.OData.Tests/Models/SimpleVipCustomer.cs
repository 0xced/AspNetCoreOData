//-----------------------------------------------------------------------------
// <copyright file="SimpleVipCustomer.cs" company=".NET Foundation">
//      Copyright (c) .NET Foundation and Contributors. All rights reserved.
//      See License.txt in the project root for license information.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.AspNetCore.OData.Tests.Models
{
    public class SimpleVipCustomer : SimpleOpenCustomer
    {
        public string VipNum { get; set; }
    }
}

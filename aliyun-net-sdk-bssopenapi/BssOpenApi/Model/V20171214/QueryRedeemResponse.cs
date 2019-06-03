/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryRedeemResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private QueryRedeem_Data data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public QueryRedeem_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QueryRedeem_Data
		{

			private long? pageNum;

			private long? pageSize;

			private long? totalCount;

			private List<QueryRedeem_RedeemItem> redeem;

			public long? PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
				}
			}

			public long? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public long? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public List<QueryRedeem_RedeemItem> Redeem
			{
				get
				{
					return redeem;
				}
				set	
				{
					redeem = value;
				}
			}

			public class QueryRedeem_RedeemItem
			{

				private string redeemId;

				private string redeemNo;

				private string status;

				private string grantedTime;

				private string effectiveTime;

				private string expiryTime;

				private string nominalValue;

				private string balance;

				private string applicableProducts;

				private string specification;

				public string RedeemId
				{
					get
					{
						return redeemId;
					}
					set	
					{
						redeemId = value;
					}
				}

				public string RedeemNo
				{
					get
					{
						return redeemNo;
					}
					set	
					{
						redeemNo = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public string GrantedTime
				{
					get
					{
						return grantedTime;
					}
					set	
					{
						grantedTime = value;
					}
				}

				public string EffectiveTime
				{
					get
					{
						return effectiveTime;
					}
					set	
					{
						effectiveTime = value;
					}
				}

				public string ExpiryTime
				{
					get
					{
						return expiryTime;
					}
					set	
					{
						expiryTime = value;
					}
				}

				public string NominalValue
				{
					get
					{
						return nominalValue;
					}
					set	
					{
						nominalValue = value;
					}
				}

				public string Balance
				{
					get
					{
						return balance;
					}
					set	
					{
						balance = value;
					}
				}

				public string ApplicableProducts
				{
					get
					{
						return applicableProducts;
					}
					set	
					{
						applicableProducts = value;
					}
				}

				public string Specification
				{
					get
					{
						return specification;
					}
					set	
					{
						specification = value;
					}
				}
			}
		}
	}
}

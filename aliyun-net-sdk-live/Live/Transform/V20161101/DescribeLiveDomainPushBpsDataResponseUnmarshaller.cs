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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveDomainPushBpsDataResponseUnmarshaller
    {
        public static DescribeLiveDomainPushBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveDomainPushBpsDataResponse describeLiveDomainPushBpsDataResponse = new DescribeLiveDomainPushBpsDataResponse();

			describeLiveDomainPushBpsDataResponse.HttpResponse = context.HttpResponse;
			describeLiveDomainPushBpsDataResponse.RequestId = context.StringValue("DescribeLiveDomainPushBpsData.RequestId");
			describeLiveDomainPushBpsDataResponse.DomainName = context.StringValue("DescribeLiveDomainPushBpsData.DomainName");
			describeLiveDomainPushBpsDataResponse.StartTime = context.StringValue("DescribeLiveDomainPushBpsData.StartTime");
			describeLiveDomainPushBpsDataResponse.EndTime = context.StringValue("DescribeLiveDomainPushBpsData.EndTime");
			describeLiveDomainPushBpsDataResponse.DataInterval = context.StringValue("DescribeLiveDomainPushBpsData.DataInterval");

			List<DescribeLiveDomainPushBpsDataResponse.DescribeLiveDomainPushBpsData_DataModule> describeLiveDomainPushBpsDataResponse_bpsDataPerInterval = new List<DescribeLiveDomainPushBpsDataResponse.DescribeLiveDomainPushBpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeLiveDomainPushBpsData.BpsDataPerInterval.Length"); i++) {
				DescribeLiveDomainPushBpsDataResponse.DescribeLiveDomainPushBpsData_DataModule dataModule = new DescribeLiveDomainPushBpsDataResponse.DescribeLiveDomainPushBpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeLiveDomainPushBpsData.BpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.BpsValue = context.StringValue("DescribeLiveDomainPushBpsData.BpsDataPerInterval["+ i +"].BpsValue");

				describeLiveDomainPushBpsDataResponse_bpsDataPerInterval.Add(dataModule);
			}
			describeLiveDomainPushBpsDataResponse.BpsDataPerInterval = describeLiveDomainPushBpsDataResponse_bpsDataPerInterval;
        
			return describeLiveDomainPushBpsDataResponse;
        }
    }
}

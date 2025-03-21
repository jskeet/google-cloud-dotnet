// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Billing.Budgets.V1Beta1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBudgetServiceClientSnippets
    {
        /// <summary>Snippet for CreateBudget</summary>
        public void CreateBudgetRequestObject()
        {
            // Snippet: CreateBudget(CreateBudgetRequest, CallSettings)
            // Create client
            BudgetServiceClient budgetServiceClient = BudgetServiceClient.Create();
            // Initialize request argument(s)
            CreateBudgetRequest request = new CreateBudgetRequest
            {
                ParentAsBillingAccountName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Budget = new Budget(),
            };
            // Make the request
            Budget response = budgetServiceClient.CreateBudget(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBudgetAsync</summary>
        public async Task CreateBudgetRequestObjectAsync()
        {
            // Snippet: CreateBudgetAsync(CreateBudgetRequest, CallSettings)
            // Additional: CreateBudgetAsync(CreateBudgetRequest, CancellationToken)
            // Create client
            BudgetServiceClient budgetServiceClient = await BudgetServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateBudgetRequest request = new CreateBudgetRequest
            {
                ParentAsBillingAccountName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Budget = new Budget(),
            };
            // Make the request
            Budget response = await budgetServiceClient.CreateBudgetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBudget</summary>
        public void UpdateBudgetRequestObject()
        {
            // Snippet: UpdateBudget(UpdateBudgetRequest, CallSettings)
            // Create client
            BudgetServiceClient budgetServiceClient = BudgetServiceClient.Create();
            // Initialize request argument(s)
            UpdateBudgetRequest request = new UpdateBudgetRequest
            {
                Budget = new Budget(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Budget response = budgetServiceClient.UpdateBudget(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBudgetAsync</summary>
        public async Task UpdateBudgetRequestObjectAsync()
        {
            // Snippet: UpdateBudgetAsync(UpdateBudgetRequest, CallSettings)
            // Additional: UpdateBudgetAsync(UpdateBudgetRequest, CancellationToken)
            // Create client
            BudgetServiceClient budgetServiceClient = await BudgetServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBudgetRequest request = new UpdateBudgetRequest
            {
                Budget = new Budget(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Budget response = await budgetServiceClient.UpdateBudgetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBudget</summary>
        public void GetBudgetRequestObject()
        {
            // Snippet: GetBudget(GetBudgetRequest, CallSettings)
            // Create client
            BudgetServiceClient budgetServiceClient = BudgetServiceClient.Create();
            // Initialize request argument(s)
            GetBudgetRequest request = new GetBudgetRequest
            {
                BudgetName = BudgetName.FromBillingAccountBudget("[BILLING_ACCOUNT]", "[BUDGET]"),
            };
            // Make the request
            Budget response = budgetServiceClient.GetBudget(request);
            // End snippet
        }

        /// <summary>Snippet for GetBudgetAsync</summary>
        public async Task GetBudgetRequestObjectAsync()
        {
            // Snippet: GetBudgetAsync(GetBudgetRequest, CallSettings)
            // Additional: GetBudgetAsync(GetBudgetRequest, CancellationToken)
            // Create client
            BudgetServiceClient budgetServiceClient = await BudgetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBudgetRequest request = new GetBudgetRequest
            {
                BudgetName = BudgetName.FromBillingAccountBudget("[BILLING_ACCOUNT]", "[BUDGET]"),
            };
            // Make the request
            Budget response = await budgetServiceClient.GetBudgetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListBudgets</summary>
        public void ListBudgetsRequestObject()
        {
            // Snippet: ListBudgets(ListBudgetsRequest, CallSettings)
            // Create client
            BudgetServiceClient budgetServiceClient = BudgetServiceClient.Create();
            // Initialize request argument(s)
            ListBudgetsRequest request = new ListBudgetsRequest
            {
                ParentAsBillingAccountName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Scope = "",
            };
            // Make the request
            PagedEnumerable<ListBudgetsResponse, Budget> response = budgetServiceClient.ListBudgets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Budget item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBudgetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Budget item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Budget> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Budget item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBudgetsAsync</summary>
        public async Task ListBudgetsRequestObjectAsync()
        {
            // Snippet: ListBudgetsAsync(ListBudgetsRequest, CallSettings)
            // Create client
            BudgetServiceClient budgetServiceClient = await BudgetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListBudgetsRequest request = new ListBudgetsRequest
            {
                ParentAsBillingAccountName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Scope = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBudgetsResponse, Budget> response = budgetServiceClient.ListBudgetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Budget item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBudgetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Budget item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Budget> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Budget item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteBudget</summary>
        public void DeleteBudgetRequestObject()
        {
            // Snippet: DeleteBudget(DeleteBudgetRequest, CallSettings)
            // Create client
            BudgetServiceClient budgetServiceClient = BudgetServiceClient.Create();
            // Initialize request argument(s)
            DeleteBudgetRequest request = new DeleteBudgetRequest
            {
                BudgetName = BudgetName.FromBillingAccountBudget("[BILLING_ACCOUNT]", "[BUDGET]"),
            };
            // Make the request
            budgetServiceClient.DeleteBudget(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBudgetAsync</summary>
        public async Task DeleteBudgetRequestObjectAsync()
        {
            // Snippet: DeleteBudgetAsync(DeleteBudgetRequest, CallSettings)
            // Additional: DeleteBudgetAsync(DeleteBudgetRequest, CancellationToken)
            // Create client
            BudgetServiceClient budgetServiceClient = await BudgetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBudgetRequest request = new DeleteBudgetRequest
            {
                BudgetName = BudgetName.FromBillingAccountBudget("[BILLING_ACCOUNT]", "[BUDGET]"),
            };
            // Make the request
            await budgetServiceClient.DeleteBudgetAsync(request);
            // End snippet
        }
    }
}

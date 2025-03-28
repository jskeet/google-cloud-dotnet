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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Kms.Inventory.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gckv = Google.Cloud.Kms.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedKeyDashboardServiceClientSnippets
    {
        /// <summary>Snippet for ListCryptoKeys</summary>
        public void ListCryptoKeysRequestObject()
        {
            // Snippet: ListCryptoKeys(ListCryptoKeysRequest, CallSettings)
            // Create client
            KeyDashboardServiceClient keyDashboardServiceClient = KeyDashboardServiceClient.Create();
            // Initialize request argument(s)
            ListCryptoKeysRequest request = new ListCryptoKeysRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListCryptoKeysResponse, gckv::CryptoKey> response = keyDashboardServiceClient.ListCryptoKeys(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gckv::CryptoKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCryptoKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gckv::CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gckv::CryptoKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gckv::CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeysAsync</summary>
        public async Task ListCryptoKeysRequestObjectAsync()
        {
            // Snippet: ListCryptoKeysAsync(ListCryptoKeysRequest, CallSettings)
            // Create client
            KeyDashboardServiceClient keyDashboardServiceClient = await KeyDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCryptoKeysRequest request = new ListCryptoKeysRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeysResponse, gckv::CryptoKey> response = keyDashboardServiceClient.ListCryptoKeysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gckv::CryptoKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCryptoKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gckv::CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gckv::CryptoKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gckv::CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeys</summary>
        public void ListCryptoKeys()
        {
            // Snippet: ListCryptoKeys(string, string, int?, CallSettings)
            // Create client
            KeyDashboardServiceClient keyDashboardServiceClient = KeyDashboardServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListCryptoKeysResponse, gckv::CryptoKey> response = keyDashboardServiceClient.ListCryptoKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gckv::CryptoKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCryptoKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gckv::CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gckv::CryptoKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gckv::CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeysAsync</summary>
        public async Task ListCryptoKeysAsync()
        {
            // Snippet: ListCryptoKeysAsync(string, string, int?, CallSettings)
            // Create client
            KeyDashboardServiceClient keyDashboardServiceClient = await KeyDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeysResponse, gckv::CryptoKey> response = keyDashboardServiceClient.ListCryptoKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gckv::CryptoKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCryptoKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gckv::CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gckv::CryptoKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gckv::CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeys</summary>
        public void ListCryptoKeysResourceNames()
        {
            // Snippet: ListCryptoKeys(ProjectName, string, int?, CallSettings)
            // Create client
            KeyDashboardServiceClient keyDashboardServiceClient = KeyDashboardServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListCryptoKeysResponse, gckv::CryptoKey> response = keyDashboardServiceClient.ListCryptoKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gckv::CryptoKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCryptoKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gckv::CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gckv::CryptoKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gckv::CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeysAsync</summary>
        public async Task ListCryptoKeysResourceNamesAsync()
        {
            // Snippet: ListCryptoKeysAsync(ProjectName, string, int?, CallSettings)
            // Create client
            KeyDashboardServiceClient keyDashboardServiceClient = await KeyDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeysResponse, gckv::CryptoKey> response = keyDashboardServiceClient.ListCryptoKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gckv::CryptoKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCryptoKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gckv::CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gckv::CryptoKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gckv::CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}

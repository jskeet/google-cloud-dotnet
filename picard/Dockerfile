# Copyright 2024 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

FROM mcr.microsoft.com/dotnet/sdk:6.0.414-jammy AS build

# TODO: We're currently bundling MakeItSo into the Docker image
# itself. This avoids having to make assumptions based on the
# command-line arguments, but leaves scope for inconsistency. At the
# moment, nothing *else* is in the Docker image... we could
# potentially include "everything needed for an unconfigured API" in
# the image, so that we could generate (but probably not build) an
# arbitrary library.

WORKDIR /src
COPY . ./
RUN dotnet build MakeItSo/MakeItSo.csproj -c Release

FROM mcr.microsoft.com/dotnet/sdk:6.0.414-jammy

# Additional tooling required to regenerate libraries and project files.
RUN apt-get update
RUN apt-get install -y unzip

WORKDIR /app
COPY --from=build /src/MakeItSo/bin/Release/net6.0 .
ENTRYPOINT ["dotnet", "MakeItSo.dll"]

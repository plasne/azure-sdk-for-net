# Azure.Communication.CallAutomation

From Folder that contains autorest.md, Run `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

```yaml
tag: package-2023-01-15-preview
model-namespace: false

require:
     - https://github.com/williamzhao87/azure-rest-api-specs/blob/84cdf62245ed9feb1e2df4d26bb6cc16de706f18/specification/communication/data-plane/CallAutomation/readme.md

title: Azure Communication Services

generation1-convenience-client: true

```

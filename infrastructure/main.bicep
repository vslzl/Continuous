param location string = 'eastus'
@allowed(['dev', 'prod'])
param environment string

// Normally I like creating the Resource Groups too in Bicep, but for this workshop that would require more permissions to give people than I'd like
targetScope = 'resourceGroup'

module app './appservice.bicep' = {
  name: 'appservice'
  params: {
    appName: 'vslzl-continuous'
    environment: environment
    location: location
  }
}
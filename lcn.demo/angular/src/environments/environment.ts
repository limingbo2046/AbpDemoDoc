import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'demo',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44369',
    redirectUri: baseUrl,
    clientId: 'demo_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone demo',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44369',
      rootNamespace: 'lcn.demo',
    },
  },
} as Environment;

import { EnvironmentModel } from "../common/models/environment-model";

export const dev: EnvironmentModel = {
  production: false,
  api: 'https://localhost:7112/api/'
};

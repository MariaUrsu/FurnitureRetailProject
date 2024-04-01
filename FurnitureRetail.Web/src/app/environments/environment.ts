
import { qa } from './environment.qa';
import { dev } from './environment.dev';
import { EnvironmentModel } from '../common/models/environment-model';

const environmentConfigurationMap: { [spa: string]: EnvironmentModel } = {
  localhost: dev,
  '': qa
};

export function environmentFactory() {
  return environmentConfigurationMap[window.location.hostname];
}

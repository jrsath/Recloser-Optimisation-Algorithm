# Recloser Optimisation Desktop Prototype
This folder contains a Windows desktop app prototype for the recloser optimisation workflow.

## Project Layout

- `RecloserOptimisation.sln` - Visual Studio solution for the WPF desktop app.
- `Directory.Build.props` - keeps generated build output in `.build/` so source folders stay easy to scan.
- `src/RecloserOptimisation.App/` - all editable app source.
- `src/RecloserOptimisation.App/MainWindow.xaml` - app shell, navigation and status bar.
- `src/RecloserOptimisation.App/Views/` - page UserControls for Dashboard, Database, Map, Settings and the other app pages.
- `src/RecloserOptimisation.App/ViewModels/` - page ViewModel scaffolds ready for moving state and commands out of the shell.
- `src/RecloserOptimisation.App/Styles/AppStyles.xaml` - shared button, panel and text styles.
- `src/RecloserOptimisation.App/Features/` - partial `MainWindow` feature files for database, processing, map, workspace, reports and actions.
- `src/RecloserOptimisation.App/Models/` and `src/RecloserOptimisation.App/Services/` - app state records and local workspace storage.
- `src/RecloserOptimisation.App/config/`, `src/RecloserOptimisation.App/data/`, `src/RecloserOptimisation.App/assets/` - bundled example data, adapters and app imagery.
- `installer/` - Inno Setup script and the developer rebuild command.
- `.build/` and `installer/build/` - generated build and installer staging folders; they are ignored.

## Download And Install
From a GitHub ZIP or release folder, the root has one installer to run:

1. Unzip the folder.
2. Read `DOWNLOAD_REQUIREMENTS.txt`.
4. Run `RecloserOptimisation-Setup.exe`.
5. Launch `RecloserOptimisation` from the Desktop shortcut.

To remove it later, use Windows Settings > Apps > Installed apps > `RecloserOptimisation` > Uninstall, or the Start Menu `Uninstall RecloserOptimisation` shortcut.

## Implemented

- Native WPF desktop app shell based on the supplied dashboard reference.
- Local prototype sign-in screen and active network/project switcher.
- Prototype account gate using `config/prototype-accounts.json`; unknown account names are denied entry.
- Per-account project list with a `New Project` prompt and per-project staged import visibility.
- Navigation across dashboard, storage, processing, model building, model explorer, validation, analysis, outages, reports and settings.
- Native file and folder import dialogs for staging source metadata.
- Native save dialogs for project-state JSON, import template CSV and empty feeder GeoJSON exports.
- Current project map with saved/offline and online modes, plus a Map/Satellite/Topography layer dropdown and detailed topology/outage/LINZ/height overlays.
- Processed storage only shows processed/model outputs; unprocessed source uploads stay in source files storage.
- Validation radar placeholder for model quality dimensions.
- Settings maintenance action for removing the local install before installing a new version.
- Import adapter catalogue for common electrical engineering, GIS, protection, SCADA, OMS, asset and customer data platforms.

## What is not implemented yet

- File parsing.
- Data normalisation.
- Network graph construction.
- Validation rules.
- Recloser placement optimisation.
- SAIDI and SAIFI calculations.

The import adapter catalogue lives in `src/RecloserOptimisation.App/config/import-adapters.json` so the future parser layer can grow from the same source list used by the UI.

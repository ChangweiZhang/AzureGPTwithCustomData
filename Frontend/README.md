<!-- Chinese -->

# ǰ��React���򿪷��ĵ�

## ���

����Ŀ��һ��ǰ��React����ʵ����������ͬ��bot���档һ��ʹ��bot framework sdk�е�direct line���Ӻ�ˣ���һ��ֱ�ӵ���asp .net core api����Ŀ������һ��hard code���û������룬�û���: admin������: 123456��

## ��������

- Node.js
- React
- TypeScript

## ��Ŀ�ṹ

```
frontend/
   ������ public/
   ������ src/
   ��   ������ components/
   ��   ������ pages/
   ��   ������ utils/
   ��   ������ App.tsx
   ��   ������ index.tsx
   ������ package.json
   ������ tsconfig.json
```

## ������

��������Ŀ��ʹ�õ���Ҫ��������

- @azure/msal-browser: Microsoft Authentication Library (MSAL) for JavaScript browser-based applications
- @azure/msal-react: React wrapper for MSAL Browser
- @azure/storage-blob: Azure Storage Blob client library for JavaScript
- @emotion/react: CSS-in-JS library for styling React components
- @emotion/styled: Styled components for Emotion
- @fluentui/react: Microsoft Fluent UI React components
- @fluentui/react-icons: Fluent UI icons for React
- @microsoft/applicationinsights-react-js: React plugin for Application Insights JavaScript SDK
- @microsoft/applicationinsights-web: Application Insights JavaScript SDK
- @mui/icons-material: Material-UI icons
- @mui/material: Material-UI React components
- @react-spring/web: React-spring animation library for web
- axios: Promise-based HTTP client for the browser and Node.js
- botframework-directlinejs: Direct Line client for JavaScript
- botframework-webchat: Web Chat component for Bot Framework
- dompurify: DOMPurify is a DOM-only, super-fast, uber-tolerant XSS sanitizer for HTML, MathML and SVG
- jwt-decode: Decode JWT tokens
- react: React library
- react-dom: React DOM library
- react-dropzone: File dropzone component for React
- react-markdown: Markdown component for React
- react-quill: Quill rich text editor for React
- react-router-dom: DOM bindings for React Router
- react-scripts: Scripts and configuration used by Create React App
- react-syntax-highlighter: Syntax highlighting component for React
- typescript: TypeScript language

## ���нű�

����Ŀ��Ŀ¼�£����������������

### `npm start`

�ڿ���ģʽ������Ӧ�ó���  
�� [http://localhost:3000](http://localhost:3000) ��������в鿴��

### `npm test`

�Խ���ʽ����ģʽ�����������г���

### `npm run build`

��Ӧ�ó��򹹽��� `build` �ļ����С�  
����������ģʽ����ȷ�ش��React�����Ż������Ի��������ܡ�

### `npm run eject`

**ע��: ����һ�����������һ���� `eject`����Ͳ��ܻ�ȥ�ˣ�**

�����Թ������ߺ�����ѡ�����⣬������ʱ `eject`�����������Ŀ��ɾ���������������

## ����淶

��Ŀʹ��Prettier��ESLint���д����ʽ���͹淶��顣��ȷ����ѭ��Ŀ�ж���Ĵ���淶��

## ���ܺͰ�ȫ

�ڿ��������У���ע����Ǳ�ڵ���������Ͱ�ȫ���ա����磬�����������ʹ�������������Լ��ٲ���Ҫ��������Ⱦ�����ڰ�ȫ���գ���ȷ�����û���������ʵ�����֤�������Է�ֹ��վ�ű���XSS�������Ȱ�ȫ©����

## ����

��Ϊ��Ŀ��������ʱ����ȷ����ѭ����淶�������ύ����֮ǰ���г�ֵĲ��ԡ�

<!-- English -->

# Frontend React Application Development Documentation

## Introduction

This project is a frontend React application that implements two different bot interfaces. One uses the direct line from the bot framework sdk to connect to the backend, and the other directly calls the asp .net core api. The project has a hard-coded username and password, with the username: admin and the password: 123456.

## Development Environment

- Node.js
- React
- TypeScript

## Project Structure

```
frontend/
   ������ public/
   ������ src/
   ��   ������ components/
   ��   ������ pages/
   ��   ������ utils/
   ��   ������ App.tsx
   ��   ������ index.tsx
   ������ package.json
   ������ tsconfig.json
```

## Dependency Packages

The following are the main dependency packages used in the project:

- @azure/msal-browser: Microsoft Authentication Library (MSAL) for JavaScript browser-based applications
- @azure/msal-react: React wrapper for MSAL Browser
- @azure/storage-blob: Azure Storage Blob client library for JavaScript
- @emotion/react: CSS-in-JS library for styling React components
- @emotion/styled: Styled components for Emotion
- @fluentui/react: Microsoft Fluent UI React components
- @fluentui/react-icons: Fluent UI icons for React
- @microsoft/applicationinsights-react-js: React plugin for Application Insights JavaScript SDK
- @microsoft/applicationinsights-web: Application Insights JavaScript SDK
- @mui/icons-material: Material-UI icons
- @mui/material: Material-UI React components
- @react-spring/web: React-spring animation library for web
- axios: Promise-based HTTP client for the browser and Node.js
- botframework-directlinejs: Direct Line client for JavaScript
- botframework-webchat: Web Chat component for Bot Framework
- dompurify: DOMPurify is a DOM-only, super-fast, uber-tolerant XSS sanitizer for HTML, MathML, and SVG
- jwt-decode: Decode JWT tokens
- react: React library
- react-dom: React DOM library
- react-dropzone: File dropzone component for React
- react-markdown: Markdown component for React
- react-quill: Quill rich text editor for React
- react-router-dom: DOM bindings for React Router
- react-scripts: Scripts and configuration used by Create React App
- react-syntax-highlighter: Syntax highlighting component for React
- typescript: TypeScript language

## Available Scripts

In the project root directory, you can run the following commands:

### `npm start`

Runs the app in development mode.  
Open [http://localhost:3000](http://localhost:3000) to view it in the browser.

### `npm test`

Launches the test runner in interactive watch mode.

### `npm run build`

Builds the app for production to the `build` folder.  
It correctly bundles React in production mode and optimizes the build for the best performance.

### `npm run eject`

**Note: This is a one-way operation. Once you `eject`, you can't go back!**

If you're not satisfied with the build tool and configuration choices, you can `eject` at any time. This command will remove the single build dependency from your project.

## Coding Standards

The project uses Prettier and ESLint for code formatting and standard check. Please ensure you follow the coding standards defined in the project.

## Performance and Security

During development, please be aware of checking for potential performance issues and security risks. For example, avoid using inline functions in components to reduce unnecessary re-rendering. For security risks, ensure proper validation and sanitization of user input to prevent security vulnerabilities such as cross-site scripting (XSS) attacks.

## Contribution

When contributing to the project, make sure to follow the coding standards and perform thorough testing before submitting any changes.
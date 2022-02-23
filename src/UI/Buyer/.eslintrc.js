module.exports = {
  parser: '@typescript-eslint/parser',
  plugins: ['@typescript-eslint'],
  extends: [
    'eslint:recommended',
    'plugin:@typescript-eslint/recommended',
    'plugin:@typescript-eslint/recommended-requiring-type-checking',
    'prettier/@typescript-eslint',
    'plugin:prettier/recommended',
  ],
  parserOptions: {
    project: './tsconfig.json',
    tsconfigRootDir: __dirname,
    ecmaVersion: 2020,
    sourceType: 'module',
  },
  rules: {
    // specify lint rules to overwrite rules inherited from the extended configs
    "@typescript-eslint/no-misused-promises": "off", // https://four51.slack.com/archives/C01DTREGY76/p1607007043017800
    "@typescript-eslint/no-floating-promises": "off", // noisy, not very useful
    "@typescript-eslint/unbound-method": [
      "error",
      {
        "ignoreStatic": true
      }
    ]
  },
}

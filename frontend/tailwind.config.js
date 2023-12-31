/** @type {import('tailwindcss').Config} */
export default {
  content: [
    "./index.html",
    "./src/**/*.{js,ts,jsx,tsx}",
  ],
  theme: {
    fontFamily: {
      'header': ['"Baloo 2"', 'sans-serif'],
      'sans': ['Roboto', 'sans-serif']
    },
    extend: {
      backgroundImage: {
        'intro-background': "url('/assets/background.png')",
      }
    },
  },
  plugins: [],
}
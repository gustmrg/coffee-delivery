/** @type {import('tailwindcss').Config} */
export default {
  content: ["./index.html", "./src/**/*.{js,ts,jsx,tsx}"],
  theme: {
    fontFamily: {
      header: ['"Baloo 2"', "sans-serif"],
      sans: ["Roboto", "sans-serif"],
    },
    colors: {
      white: "#FFFFFF",
      background: "#FAFAFA",
      yellow: {
        300: "#F1E9C9",
        500: "#DBAC2C",
        700: "#C47F17",
      },
      purple: {
        300: "#EBE5F9",
        500: "#8047F8",
        700: "#4B2995",
      },
      base: {
        button: "#E6E5E",
        card: "#F3F2F2",
        title: "#272221",
        subtitle: "#403937",
        text: "#574F4D",
        label: "#8D8686",
        hover: "#D7D5D5",
        input: "#EDEDED",
      },
    },
    extend: {
      backgroundImage: {
        "intro-background": "url('/assets/background.png')",
      },
    },
  },
  plugins: [],
};

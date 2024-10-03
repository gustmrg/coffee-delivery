import Header from "./components/Header";
import Intro from "./components/Intro";
import CoffeeList from "./components/CoffeeList";

export default function App() {
  return (
    <>
      <Header />
      <Intro />
      <div className="">
        <h3 className="font-extrabold font-baloo text-2xl ml-6 my-6">
          Nossos cafes
        </h3>
        <CoffeeList />
      </div>
    </>
  );
}

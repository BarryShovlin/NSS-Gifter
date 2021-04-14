import React from "react";
import "./App.css";
import { PostProvider } from "./providers/PostProvider";
import PostList from "./components/PostList";
import PostForm from "./components/PostForm";
import SearchPosts from "./components/SearchPost";

function App() {
  return (
    <div className="App">
      <PostProvider>
        <PostList />
        <SearchPosts />
        <PostForm />
      </PostProvider>
    </div>
  );
}

export default App;
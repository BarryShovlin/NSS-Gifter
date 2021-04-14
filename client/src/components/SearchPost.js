import react, { useState, useContext } from "react";
import { PostContext } from "../providers/PostProvider";

export const SearchPosts = () => {
    const { searchPost } = useContext(PostContext);
    const [post, setPost] = useState("");

    const handleControlledInputChange = (event) => {
        setPost(event.target.value);
    }

    return (
        <section className="search_post">
            <fieldset>
                <div className="form-group">
                    <label htmlFor="search">Search</label>
                    <input type="text" id="search" onChange={handleControlledInputChange} required className="form-control" placeholder="Search..." value={post} />

                </div>
            </fieldset>
            <div className="save_post btn btn-primary" onClick={(event) => {
                event.preventDefault();
                searchPost(post)
            }}>Search</div>
        </section>
    )
}

export default SearchPosts;
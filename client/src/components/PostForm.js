import React, { useContext, useEffect, useState } from "react";
import { PostContext } from "../providers/PostProvider.js";


export const PostForm = () => {
    const { addPost, getAllPosts } = useContext(PostContext);



    const [post, setPost] = useState({
        title: "",
        imageUrl: "",
        caption: "",
        userProfileId: 1,
    });

    useEffect(() => {
        getAllPosts();
    }, [])

    const handleControlledInputChangePost = (event) => {
        const freshPost = { ...post };

        freshPost[event.target.id] = event.target.value
        setPost(freshPost);
    }

    const handleSave = () => {
        addPost({
            title: post.title,
            imageUrl: post.imageUrl,
            caption: post.caption,
            userProfileId: 1
        })
    };

    return (
        <section className="post_form">
            <h2 className="post_form_header">Add a new Post</h2>
            <fieldset>
                <div className="form-group">
                    <label htmlFor="title">Title:</label>
                    <input
                        type="text" id="title" onChange={handleControlledInputChangePost} required autoFocus className="form-control" placeholder="Title" value={post.title} />
                </div>
            </fieldset>
            <fieldset>
                <div className="form-group">
                    <label htmlFor="caption">Caption:</label>
                    <input
                        type="text" id="caption" onChange={handleControlledInputChangePost} required autoFocus className="form-control" placeholder="Caption" value={post.caption} />
                </div>
            </fieldset>
            <fieldset>
                <div className="form-group">
                    <label htmlFor="url">Image Url:</label>
                    <input
                        type="text" id="imageUrl" onChange={handleControlledInputChangePost} required autoFocus className="form-control" placeholder="Image Url" value={post.imageUrl} />
                </div>
            </fieldset>
            <div className="savePost btn btn-primary" onClick={(event) => {
                event.preventDefault();
                handleSave()
            }}>Save This Post
            </div>
        </section>
    )
};

export default PostForm
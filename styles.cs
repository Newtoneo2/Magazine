/* About Section */
.about {
    padding: 4rem 5%;
    text-align: center;
    background: #fff;
}

.wiki-link {
    display: inline-block;
    margin-top: 15px;
    color: #0044cc;
    text-decoration: underline;
    font-weight: bold;
}

/* Gallery Section */
.gallery {
    padding: 4rem 5%;
    background: #f9f9f9;
}

.gallery h2 {
    text-align: center;
    margin-bottom: 2rem;
}

.gallery-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
    gap: 15px;
}

.gallery-item img {
    width: 100%;
    height: 250px;
    object-fit: cover;
    border-radius: 8px;
    transition: transform 0.3s ease;
}

.gallery-item img:hover {
    transform: scale(1.05);
}

.gallery-item p {
    margin-top: 10px;
    font-weight: bold;
    text-align: center;
}

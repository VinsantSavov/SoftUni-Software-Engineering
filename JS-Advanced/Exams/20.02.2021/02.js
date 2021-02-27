class Story{
    constructor(title, creator){
        this.title = title;
        this.creator = creator;
        this._comments = [];
        this._likes = new Set();
    }

    get likes(){
        if(this._likes.size == 0){
            return `${this.title} has 0 likes`;
        }

        const key = this._likes.values().next();

        if(this._likes.size == 1){
            return `${key.value} likes this story!`;
        }

        return `${key.value} and ${this._likes.size - 1} others like this story!`;
    }

    like(username){
        if(this._likes.has(username)){
            throw new Error("You can't like the same story twice!");
        }

        if(username == this.creator){
            throw new Error("You can't like your own story!");
        }

        this._likes.add(username);

        return `${username} liked ${this.title}!`;
    }

    dislike(username){
        if(!this._likes.has(username)){
            throw new Error("You can't dislike this story!");
        }

        this._likes.delete(username);

        return `${username} disliked ${this.title}`;
    }

    comment(username, content, id){
        const comment = this._comments.find(c => c.Id == id);
        const count = this._comments.length;

        if(id == undefined || comment == undefined || comment == null){
            const newComment = {
                Id: count + 1,
                Username: username,
                Content: content,
                Replies: [],
            }

            this._comments.push(newComment);
            return `${username} commented on ${this.title}`;
        }

        const newReply ={
            Id: `${comment.Id}.${comment.Replies.length + 1}`,
            Username: username,
            Content: content,
        }

        comment.Replies.push(newReply);
        return "You replied successfully";
    }

    toString(sortingType){
        const result = [];
        result.push(`Title: ${this.title}`);
        result.push(`Creator: ${this.creator}`);
        result.push(`Likes: ${this._likes.size}`);
        result.push('Comments:');

        let sortedComments = [];

        if(sortingType == 'asc'){
            sortedComments = this._comments.sort((a, b) => a.Id - b.Id);
            sortedComments.map(c => c.Replies = c.Replies.sort((a, b) => a.Id - b.Id));

        }else if(sortingType == 'desc'){
            sortedComments = this._comments.sort((a, b) => b.Id - a.Id);
            sortedComments.map(c => c.Replies = c.Replies.sort((a, b) => b.Id - a.Id));

        }else if(sortingType == 'username'){
            sortedComments = this._comments.sort((a, b) => a.Username.localeCompare(b.Username));
            sortedComments.map(c => c.Replies = c.Replies.sort((a, b) => a.Username.localeCompare(b.Username)));

        }

        for(let com of sortedComments){
            result.push(`-- ${com.Id}. ${com.Username}: ${com.Content}`);

            if(com.Replies.length > 0){
                for(let rep of com.Replies){
                    result.push(`--- ${rep.Id}. ${rep.Username}: ${rep.Content}`);
                }
            }
        }

        return result.join('\n');
    }
}

let art = new Story("My Story", "Anny");
art.like("John");
console.log(art.likes);
//console.log(art.dislike("Sally"));
console.log(art.like("Ivan"));
console.log(art.like("Steven"));
console.log(art.likes);
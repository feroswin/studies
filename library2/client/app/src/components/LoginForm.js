import React, {useEffect, useState} from 'react';

const LoginForm = () => {

    const [email, setEmail] = useState(null)
    const [password, setPassword] = useState(null)

    useEffect(() =>{
        fetch('api/registration', {
            headers : {
                'Content-Type': 'application/json',
                'Accept': 'application/json'
            }
        })
            .then(res => res.json())
            .then(res => setEmail(res.email))
    })

    return (
        <div>
            <input
                onChange={e => setEmail(e.target.value)}
                value={email}
                type="email"
                placeholder="Email"
            />
            <input
                onChange={e => setPassword(e.target.value)}
                type="password"
                value={password}
                placeholder="password"
            />
            <button type="submit">dgdgf</button>
        </div>
    );
};

export default LoginForm;
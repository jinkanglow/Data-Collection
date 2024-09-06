self.addEventListener('install', event => {
    event.waitUntil(
        caches.open('DataCollection-cache').then(cache => {
            return cache.addAll([
                '/',
                'index.html',
                'manifest.json',
                // Add other assets to cache
            ]);
        })
    );
});

self.addEventListener('fetch', event => {
    event.respondWith(
        caches.match(event.request).then(response => {
            return response || fetch(event.request);
        })
    );
});
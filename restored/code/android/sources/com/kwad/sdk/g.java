package com.kwad.sdk;

/* JADX INFO: loaded from: classes3.dex */
public final class g {
    private volatile boolean aFX = false;
    private com.kwad.sdk.g.a aFY;

    public static g ag(final long j) {
        return f(new com.kwad.sdk.g.a() { // from class: com.kwad.sdk.g.1
            @Override // com.kwad.sdk.g.a
            public final void accept(Object obj) {
                p.am(j);
            }
        });
    }

    public static g ah(final long j) {
        return f(new com.kwad.sdk.g.a() { // from class: com.kwad.sdk.g.2
            @Override // com.kwad.sdk.g.a
            public final void accept(Object obj) {
                p.an(j);
            }
        });
    }

    public static g ai(final long j) {
        return f(new com.kwad.sdk.g.a() { // from class: com.kwad.sdk.g.3
            @Override // com.kwad.sdk.g.a
            public final void accept(Object obj) {
                p.aq(j);
            }
        });
    }

    public static g aj(final long j) {
        return f(new com.kwad.sdk.g.a() { // from class: com.kwad.sdk.g.4
            @Override // com.kwad.sdk.g.a
            public final void accept(Object obj) {
                p.ar(j);
            }
        });
    }

    private static g f(com.kwad.sdk.g.a aVar) {
        return new g(aVar);
    }

    private g(com.kwad.sdk.g.a aVar) {
        this.aFY = aVar;
    }

    public final synchronized void report() {
        if (this.aFY != null && !this.aFX) {
            this.aFY.accept(null);
            this.aFX = true;
        }
    }
}

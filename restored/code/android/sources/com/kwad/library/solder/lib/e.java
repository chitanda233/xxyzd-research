package com.kwad.library.solder.lib;

import java.util.Collections;
import java.util.HashMap;
import java.util.Map;
import java.util.concurrent.Callable;
import java.util.concurrent.Future;

/* JADX INFO: loaded from: classes3.dex */
public final class e implements com.kwad.library.solder.lib.a.d {
    private final com.kwad.library.solder.lib.ext.c aEl;
    private final com.kwad.library.solder.lib.a.c aEn;
    private final com.kwad.library.solder.lib.a.f aEo;
    private final com.kwad.library.solder.lib.a.b aEp;
    private final com.kwad.library.solder.lib.ext.a aEq;
    private Map<String, b> aEr;

    public e(com.kwad.library.solder.lib.a.c cVar, com.kwad.library.solder.lib.a.f fVar, com.kwad.library.solder.lib.a.b bVar, com.kwad.library.solder.lib.ext.c cVar2, com.kwad.library.solder.lib.ext.a aVar) {
        this.aEn = cVar;
        this.aEo = fVar;
        this.aEp = bVar;
        this.aEl = cVar2;
        this.aEq = aVar;
    }

    public final com.kwad.library.solder.lib.a.e a(com.kwad.library.solder.lib.a.e eVar, a aVar) {
        if (eVar.Ej() == null) {
            eVar.a(this);
        }
        eVar.En();
        eVar.Ek();
        aVar.j(eVar);
        return eVar;
    }

    public final b a(com.kwad.library.solder.lib.a.e eVar, int i) {
        return b(eVar, a.a(this, 16));
    }

    private b b(final com.kwad.library.solder.lib.a.e eVar, final a aVar) {
        b bVarCx = cx(eVar.En());
        if (bVarCx != null) {
            bVarCx.cancel();
        }
        eVar.a(this);
        b bVar = new b(eVar, this.aEl.EG().submit(new Callable<com.kwad.library.solder.lib.a.e>() { // from class: com.kwad.library.solder.lib.e.1
            /* JADX INFO: Access modifiers changed from: private */
            @Override // java.util.concurrent.Callable
            /* JADX INFO: renamed from: Eb, reason: merged with bridge method [inline-methods] */
            public com.kwad.library.solder.lib.a.e call() {
                return e.this.a(eVar, aVar);
            }
        }));
        a(eVar.En(), bVar);
        return bVar;
    }

    public final void i(com.kwad.library.solder.lib.a.e eVar) {
        b bVarCx = cx(eVar.En());
        if (bVarCx != null) {
            bVarCx.cancel();
        }
        a(eVar.En(), (b) null);
    }

    private synchronized b cx(String str) {
        Map<String, b> mapE = e(this.aEr);
        this.aEr = mapE;
        if (str == null) {
            return null;
        }
        return mapE.get(str);
    }

    private synchronized void a(String str, b bVar) {
        Map<String, b> mapE = e(this.aEr);
        this.aEr = mapE;
        if (str != null) {
            mapE.put(str, bVar);
        }
    }

    private static Map<String, b> e(Map<String, b> map) {
        return (map == null || map == Collections.EMPTY_MAP) ? new HashMap() : map;
    }

    @Override // com.kwad.library.solder.lib.a.d
    public final com.kwad.library.solder.lib.ext.c DW() {
        return this.aEl;
    }

    @Override // com.kwad.library.solder.lib.a.d
    public final com.kwad.library.solder.lib.a.c DX() {
        return this.aEn;
    }

    @Override // com.kwad.library.solder.lib.a.d
    public final com.kwad.library.solder.lib.a.f DY() {
        return this.aEo;
    }

    @Override // com.kwad.library.solder.lib.a.d
    public final com.kwad.library.solder.lib.a.b DZ() {
        return this.aEp;
    }

    @Override // com.kwad.library.solder.lib.a.d
    public final com.kwad.library.solder.lib.ext.a Ea() {
        return this.aEq;
    }

    public static abstract class a {
        final com.kwad.library.solder.lib.a.d aEv;

        public abstract void j(com.kwad.library.solder.lib.a.e eVar);

        public static a a(com.kwad.library.solder.lib.a.d dVar, int i) {
            if (i == 1) {
                return new b(dVar);
            }
            return new C0492a(dVar);
        }

        public a(com.kwad.library.solder.lib.a.d dVar) {
            this.aEv = dVar;
        }

        static class b extends a {
            b(com.kwad.library.solder.lib.a.d dVar) {
                super(dVar);
            }

            @Override // com.kwad.library.solder.lib.e.a
            public final void j(com.kwad.library.solder.lib.a.e eVar) {
                this.aEv.DY().k(eVar);
            }
        }

        /* JADX INFO: renamed from: com.kwad.library.solder.lib.e$a$a, reason: collision with other inner class name */
        static class C0492a extends a {
            C0492a(com.kwad.library.solder.lib.a.d dVar) {
                super(dVar);
            }

            @Override // com.kwad.library.solder.lib.e.a
            public final void j(com.kwad.library.solder.lib.a.e eVar) {
                this.aEv.DX().g(eVar);
            }
        }
    }

    public static class b {
        private final com.kwad.library.solder.lib.a.e aEw;
        private final Future<com.kwad.library.solder.lib.a.e> aEx;

        public b(com.kwad.library.solder.lib.a.e eVar, Future<com.kwad.library.solder.lib.a.e> future) {
            this.aEw = eVar;
            this.aEx = future;
        }

        public final void cancel() {
            this.aEw.cancel();
            this.aEx.cancel(true);
        }
    }
}

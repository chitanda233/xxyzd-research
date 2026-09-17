package com.kwad.framework.filedownloader.b;

import android.util.SparseArray;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class b implements com.kwad.framework.filedownloader.b.a {
    final SparseArray<com.kwad.framework.filedownloader.d.c> aAx = new SparseArray<>();
    final SparseArray<List<com.kwad.framework.filedownloader.d.a>> aAy = new SparseArray<>();

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(int i, long j, String str, String str2) {
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(int i, String str, long j, long j2, int i2) {
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(int i, Throwable th) {
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(int i, Throwable th, long j) {
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void b(int i, long j) {
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void cr(int i) {
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void cw(int i) {
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void d(int i, long j) {
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void w(int i, int i2) {
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final com.kwad.framework.filedownloader.d.c cs(int i) {
        com.kwad.framework.filedownloader.d.c cVar;
        synchronized (this.aAx) {
            cVar = this.aAx.get(i);
        }
        return cVar;
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final List<com.kwad.framework.filedownloader.d.a> ct(int i) {
        List<com.kwad.framework.filedownloader.d.a> list;
        try {
            ArrayList arrayList = new ArrayList();
            synchronized (this.aAy) {
                list = this.aAy.get(i);
            }
            if (list != null) {
                arrayList.addAll(list);
            }
            return arrayList;
        } catch (Exception unused) {
            return new ArrayList();
        }
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void cu(int i) {
        try {
            synchronized (this.aAy) {
                this.aAy.remove(i);
            }
        } catch (Exception unused) {
        }
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(com.kwad.framework.filedownloader.d.a aVar) {
        List<com.kwad.framework.filedownloader.d.a> arrayList;
        try {
            int id = aVar.getId();
            synchronized (this.aAy) {
                arrayList = this.aAy.get(id);
                if (arrayList == null) {
                    arrayList = new ArrayList<>();
                    this.aAy.put(id, arrayList);
                }
            }
            arrayList.add(aVar);
        } catch (Exception unused) {
        }
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(int i, int i2, long j) {
        List<com.kwad.framework.filedownloader.d.a> list;
        synchronized (this.aAy) {
            list = this.aAy.get(i);
        }
        if (list == null) {
            return;
        }
        for (com.kwad.framework.filedownloader.d.a aVar : list) {
            if (aVar.getIndex() == i2) {
                aVar.aa(j);
                return;
            }
        }
    }

    private void d(com.kwad.framework.filedownloader.d.c cVar) {
        synchronized (this.aAx) {
            this.aAx.put(cVar.getId(), cVar);
        }
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void b(com.kwad.framework.filedownloader.d.c cVar) {
        if (cVar == null) {
            com.kwad.framework.filedownloader.f.d.d(this, "update but model == null!", new Object[0]);
            return;
        }
        if (cs(cVar.getId()) != null) {
            synchronized (this.aAx) {
                this.aAx.remove(cVar.getId());
                this.aAx.put(cVar.getId(), cVar);
            }
            return;
        }
        d(cVar);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final boolean cv(int i) {
        synchronized (this.aAx) {
            this.aAx.remove(i);
        }
        return true;
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void clear() {
        synchronized (this.aAx) {
            this.aAx.clear();
        }
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void c(int i, long j) {
        cv(i);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final com.kwad.framework.filedownloader.b.a.InterfaceC0482a Cd() {
        return new a();
    }

    class a implements com.kwad.framework.filedownloader.b.a.InterfaceC0482a {
        @Override // com.kwad.framework.filedownloader.b.a.InterfaceC0482a
        public final void Ce() {
        }

        @Override // com.kwad.framework.filedownloader.b.a.InterfaceC0482a
        public final void a(int i, com.kwad.framework.filedownloader.d.c cVar) {
        }

        @Override // com.kwad.framework.filedownloader.b.a.InterfaceC0482a
        public final void c(com.kwad.framework.filedownloader.d.c cVar) {
        }

        a() {
        }

        @Override // java.lang.Iterable
        public final Iterator<com.kwad.framework.filedownloader.d.c> iterator() {
            return b.this.new C0483b();
        }
    }

    /* JADX INFO: renamed from: com.kwad.framework.filedownloader.b.b$b, reason: collision with other inner class name */
    class C0483b implements Iterator<com.kwad.framework.filedownloader.d.c> {
        @Override // java.util.Iterator
        public final boolean hasNext() {
            return false;
        }

        @Override // java.util.Iterator
        public final /* bridge */ /* synthetic */ com.kwad.framework.filedownloader.d.c next() {
            return null;
        }

        @Override // java.util.Iterator
        public final void remove() {
        }

        C0483b() {
        }
    }
}

package a.e.a;

import android.database.ContentObserver;

/* JADX INFO: loaded from: classes.dex */
public class c extends ContentObserver {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public String f29a;
    public int b;
    public b c;

    public c(b bVar, int i, String str) {
        super(null);
        this.c = bVar;
        this.b = i;
        this.f29a = str;
    }

    @Override // android.database.ContentObserver
    public void onChange(boolean z) {
        b bVar = this.c;
        if (bVar != null) {
            bVar.b(this.b, this.f29a);
        }
    }
}

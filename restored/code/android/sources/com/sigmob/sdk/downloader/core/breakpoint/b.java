package com.sigmob.sdk.downloader.core.breakpoint;

import android.database.Cursor;

/* JADX INFO: loaded from: classes3.dex */
public class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final int f3380a;
    private final long b;
    private final long c;
    private final long d;

    public b(Cursor cursor) {
        int columnIndex = cursor.getColumnIndex(f.h);
        this.f3380a = columnIndex >= 0 ? cursor.getInt(columnIndex) : 0;
        int columnIndex2 = cursor.getColumnIndex(f.j);
        this.b = columnIndex2 >= 0 ? cursor.getInt(columnIndex2) : 0L;
        int columnIndex3 = cursor.getColumnIndex(f.k);
        this.c = columnIndex3 >= 0 ? cursor.getInt(columnIndex3) : 0L;
        int columnIndex4 = cursor.getColumnIndex(f.l);
        this.d = columnIndex4 >= 0 ? cursor.getInt(columnIndex4) : 0L;
    }

    public int a() {
        return this.f3380a;
    }

    public long b() {
        return this.b;
    }

    public long c() {
        return this.c;
    }

    public long d() {
        return this.d;
    }

    public a e() {
        return new a(this.b, this.c, this.d);
    }
}

package com.kwad.framework.filedownloader.d;

import android.content.ContentValues;
import com.kwad.framework.filedownloader.f.f;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private long aAY;
    private long aAZ;
    private long aBa;
    private int id;
    private int index;

    public final int getId() {
        return this.id;
    }

    public final void setId(int i) {
        this.id = i;
    }

    public final int getIndex() {
        return this.index;
    }

    public final void setIndex(int i) {
        this.index = i;
    }

    public final long getStartOffset() {
        return this.aAY;
    }

    public final void setStartOffset(long j) {
        this.aAY = j;
    }

    public final long Df() {
        return this.aAZ;
    }

    public final void aa(long j) {
        this.aAZ = j;
    }

    public final long Dg() {
        return this.aBa;
    }

    public final void ab(long j) {
        this.aBa = j;
    }

    public final ContentValues Dh() {
        ContentValues contentValues = new ContentValues();
        contentValues.put("id", Integer.valueOf(this.id));
        contentValues.put("connectionIndex", Integer.valueOf(this.index));
        contentValues.put("startOffset", Long.valueOf(this.aAY));
        contentValues.put("currentOffset", Long.valueOf(this.aAZ));
        contentValues.put("endOffset", Long.valueOf(this.aBa));
        return contentValues;
    }

    public static long y(List<a> list) {
        long jDf = 0;
        for (a aVar : list) {
            jDf += aVar.Df() - aVar.getStartOffset();
        }
        return jDf;
    }

    public final String toString() {
        return f.c("id[%d] index[%d] range[%d, %d) current offset(%d)", Integer.valueOf(this.id), Integer.valueOf(this.index), Long.valueOf(this.aAY), Long.valueOf(this.aBa), Long.valueOf(this.aAZ));
    }
}

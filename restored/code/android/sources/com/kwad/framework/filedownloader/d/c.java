package com.kwad.framework.filedownloader.d;

import android.content.ContentValues;
import android.os.Parcel;
import android.os.Parcelable;
import com.kwad.framework.filedownloader.f.f;
import java.util.concurrent.atomic.AtomicInteger;
import java.util.concurrent.atomic.AtomicLong;

/* JADX INFO: loaded from: classes3.dex */
public final class c implements Parcelable {
    public static final Parcelable.Creator<c> CREATOR = new Parcelable.Creator<c>() { // from class: com.kwad.framework.filedownloader.d.c.1
        @Override // android.os.Parcelable.Creator
        public final /* synthetic */ c createFromParcel(Parcel parcel) {
            return e(parcel);
        }

        @Override // android.os.Parcelable.Creator
        public final /* synthetic */ c[] newArray(int i) {
            return cM(i);
        }

        private static c e(Parcel parcel) {
            return new c(parcel);
        }

        private static c[] cM(int i) {
            return new c[i];
        }
    };
    private boolean aCM;
    private final AtomicInteger aCN;
    private final AtomicLong aCO;
    private long aCP;
    private String aCQ;
    private String aCR;
    private int aCS;
    private boolean aCz;
    private String app;
    private String filename;
    private int id;
    private String url;

    @Override // android.os.Parcelable
    public final int describeContents() {
        return 0;
    }

    public final void setId(int i) {
        this.id = i;
    }

    public final void setUrl(String str) {
        this.url = str;
    }

    public final void d(String str, boolean z) {
        this.app = str;
        this.aCM = z;
    }

    public final void d(byte b) {
        this.aCN.set(b);
    }

    public final void ac(long j) {
        this.aCO.set(j);
    }

    public final void ad(long j) {
        this.aCO.addAndGet(j);
    }

    public final void ae(long j) {
        this.aCz = j > 2147483647L;
        this.aCP = j;
    }

    public final int getId() {
        return this.id;
    }

    public final String getUrl() {
        return this.url;
    }

    public final String getPath() {
        return this.app;
    }

    public final String getTargetFilePath() {
        return f.a(getPath(), AN(), getFilename());
    }

    public final String CB() {
        if (getTargetFilePath() == null) {
            return null;
        }
        return f.ck(getTargetFilePath());
    }

    public final byte AT() {
        return (byte) this.aCN.get();
    }

    public final long Dj() {
        return this.aCO.get();
    }

    public final long getTotal() {
        return this.aCP;
    }

    public final boolean isChunked() {
        return this.aCP == -1;
    }

    public final String Dk() {
        return this.aCR;
    }

    public final void ce(String str) {
        this.aCR = str;
    }

    private String Dl() {
        return this.aCQ;
    }

    public final void cf(String str) {
        this.aCQ = str;
    }

    public final void cg(String str) {
        this.filename = str;
    }

    public final boolean AN() {
        return this.aCM;
    }

    public final String getFilename() {
        return this.filename;
    }

    public final void cL(int i) {
        this.aCS = i;
    }

    public final int Dm() {
        return this.aCS;
    }

    public final void Dn() {
        this.aCS = 1;
    }

    public final ContentValues Dh() {
        ContentValues contentValues = new ContentValues();
        contentValues.put("_id", Integer.valueOf(getId()));
        contentValues.put("url", getUrl());
        contentValues.put("path", getPath());
        contentValues.put("status", Byte.valueOf(AT()));
        contentValues.put("sofar", Long.valueOf(Dj()));
        contentValues.put("total", Long.valueOf(getTotal()));
        contentValues.put("errMsg", Dl());
        contentValues.put(com.sigmob.sdk.downloader.core.breakpoint.f.c, Dk());
        contentValues.put("connectionCount", Integer.valueOf(Dm()));
        contentValues.put("pathAsDirectory", Boolean.valueOf(AN()));
        if (AN() && getFilename() != null) {
            contentValues.put(com.sigmob.sdk.downloader.core.breakpoint.f.e, getFilename());
        }
        return contentValues;
    }

    public final boolean AZ() {
        return this.aCz;
    }

    public final String toString() {
        return f.c("id[%d], url[%s], path[%s], status[%d], sofar[%s], total[%d], etag[%s], %s", Integer.valueOf(this.id), this.url, this.app, Integer.valueOf(this.aCN.get()), this.aCO, Long.valueOf(this.aCP), this.aCR, super.toString());
    }

    @Override // android.os.Parcelable
    public final void writeToParcel(Parcel parcel, int i) {
        parcel.writeInt(this.id);
        parcel.writeString(this.url);
        parcel.writeString(this.app);
        parcel.writeByte(this.aCM ? (byte) 1 : (byte) 0);
        parcel.writeString(this.filename);
        parcel.writeByte((byte) this.aCN.get());
        parcel.writeLong(this.aCO.get());
        parcel.writeLong(this.aCP);
        parcel.writeString(this.aCQ);
        parcel.writeString(this.aCR);
        parcel.writeInt(this.aCS);
        parcel.writeByte(this.aCz ? (byte) 1 : (byte) 0);
    }

    public c() {
        this.aCO = new AtomicLong();
        this.aCN = new AtomicInteger();
    }

    protected c(Parcel parcel) {
        this.id = parcel.readInt();
        this.url = parcel.readString();
        this.app = parcel.readString();
        this.aCM = parcel.readByte() != 0;
        this.filename = parcel.readString();
        this.aCN = new AtomicInteger(parcel.readByte());
        this.aCO = new AtomicLong(parcel.readLong());
        this.aCP = parcel.readLong();
        this.aCQ = parcel.readString();
        this.aCR = parcel.readString();
        this.aCS = parcel.readInt();
        this.aCz = parcel.readByte() != 0;
    }
}

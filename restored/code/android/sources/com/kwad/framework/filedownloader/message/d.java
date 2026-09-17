package com.kwad.framework.filedownloader.message;

import android.os.Parcel;

/* JADX INFO: loaded from: classes3.dex */
public abstract class d extends MessageSnapshot {
    d(int i2) {
        super(i2);
        this.aCz = true;
    }

    d(Parcel parcel) {
        super(parcel);
    }

    @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
    public final int CW() {
        if (Da() > 2147483647L) {
            return Integer.MAX_VALUE;
        }
        return (int) Da();
    }

    @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
    public final int CX() {
        if (CY() > 2147483647L) {
            return Integer.MAX_VALUE;
        }
        return (int) CY();
    }

    public static class f extends d {
        private final long aCx;
        private final long totalBytes;

        public byte AT() {
            return (byte) 1;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public int describeContents() {
            return 0;
        }

        f(f fVar) {
            this(fVar.getId(), fVar.Da(), fVar.CY());
        }

        f(int i, long j, long j2) {
            super(i);
            this.aCx = j;
            this.totalBytes = j2;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final long Da() {
            return this.aCx;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final long CY() {
            return this.totalBytes;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public void writeToParcel(Parcel parcel, int i) {
            super.writeToParcel(parcel, i);
            parcel.writeLong(this.aCx);
            parcel.writeLong(this.totalBytes);
        }

        f(Parcel parcel) {
            super(parcel);
            this.aCx = parcel.readLong();
            this.totalBytes = parcel.readLong();
        }
    }

    public static class c extends d {
        private final String aAT;
        private final boolean aCw;
        private final String fileName;
        private final long totalBytes;

        @Override // com.kwad.framework.filedownloader.message.c
        public final byte AT() {
            return (byte) 2;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public final int describeContents() {
            return 0;
        }

        c(int i, boolean z, long j, String str, String str2) {
            super(i);
            this.aCw = z;
            this.totalBytes = j;
            this.aAT = str;
            this.fileName = str2;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public final void writeToParcel(Parcel parcel, int i) {
            super.writeToParcel(parcel, i);
            parcel.writeByte(this.aCw ? (byte) 1 : (byte) 0);
            parcel.writeLong(this.totalBytes);
            parcel.writeString(this.aAT);
            parcel.writeString(this.fileName);
        }

        c(Parcel parcel) {
            super(parcel);
            this.aCw = parcel.readByte() != 0;
            this.totalBytes = parcel.readLong();
            this.aAT = parcel.readString();
            this.fileName = parcel.readString();
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final String getFileName() {
            return this.fileName;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final boolean CO() {
            return this.aCw;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final long CY() {
            return this.totalBytes;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final String getEtag() {
            return this.aAT;
        }
    }

    public static class g extends d {
        private final long aCx;

        @Override // com.kwad.framework.filedownloader.message.c
        public final byte AT() {
            return (byte) 3;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public final int describeContents() {
            return 0;
        }

        g(int i, long j) {
            super(i);
            this.aCx = j;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final long Da() {
            return this.aCx;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public final void writeToParcel(Parcel parcel, int i) {
            super.writeToParcel(parcel, i);
            parcel.writeLong(this.aCx);
        }

        g(Parcel parcel) {
            super(parcel);
            this.aCx = parcel.readLong();
        }
    }

    public static class a extends b implements com.kwad.framework.filedownloader.message.b {
        a(int i, boolean z, long j) {
            super(i, true, j);
        }
    }

    public static class b extends d {
        private final boolean aCv;
        private final long totalBytes;

        @Override // com.kwad.framework.filedownloader.message.c
        public final byte AT() {
            return (byte) -3;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public int describeContents() {
            return 0;
        }

        b(int i, boolean z, long j) {
            super(i);
            this.aCv = z;
            this.totalBytes = j;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public void writeToParcel(Parcel parcel, int i) {
            super.writeToParcel(parcel, i);
            parcel.writeByte(this.aCv ? (byte) 1 : (byte) 0);
            parcel.writeLong(this.totalBytes);
        }

        b(Parcel parcel) {
            super(parcel);
            this.aCv = parcel.readByte() != 0;
            this.totalBytes = parcel.readLong();
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final long CY() {
            return this.totalBytes;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final boolean CZ() {
            return this.aCv;
        }
    }

    /* JADX INFO: renamed from: com.kwad.framework.filedownloader.message.d$d, reason: collision with other inner class name */
    public static class C0489d extends d {
        private final long aCx;
        private final Throwable aCy;

        @Override // com.kwad.framework.filedownloader.message.c
        public byte AT() {
            return (byte) -1;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public int describeContents() {
            return 0;
        }

        C0489d(int i, long j, Throwable th) {
            super(i);
            this.aCx = j;
            this.aCy = th;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final long Da() {
            return this.aCx;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final Throwable Db() {
            return this.aCy;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public void writeToParcel(Parcel parcel, int i) {
            super.writeToParcel(parcel, i);
            parcel.writeLong(this.aCx);
            parcel.writeSerializable(this.aCy);
        }

        C0489d(Parcel parcel) {
            super(parcel);
            this.aCx = parcel.readLong();
            this.aCy = (Throwable) parcel.readSerializable();
        }
    }

    public static class h extends C0489d {
        private final int aCe;

        @Override // com.kwad.framework.filedownloader.message.d.C0489d, com.kwad.framework.filedownloader.message.c
        public final byte AT() {
            return (byte) 5;
        }

        @Override // com.kwad.framework.filedownloader.message.d.C0489d, com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public final int describeContents() {
            return 0;
        }

        h(int i, long j, Throwable th, int i2) {
            super(i, j, th);
            this.aCe = i2;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final int AX() {
            return this.aCe;
        }

        @Override // com.kwad.framework.filedownloader.message.d.C0489d, com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public final void writeToParcel(Parcel parcel, int i) {
            super.writeToParcel(parcel, i);
            parcel.writeInt(this.aCe);
        }

        h(Parcel parcel) {
            super(parcel);
            this.aCe = parcel.readInt();
        }
    }

    public static class i extends j implements com.kwad.framework.filedownloader.message.b {
        i(int i, long j, long j2) {
            super(i, j, j2);
        }
    }

    public static class j extends f implements MessageSnapshot.a {
        @Override // com.kwad.framework.filedownloader.message.d.f, com.kwad.framework.filedownloader.message.c
        public final byte AT() {
            return (byte) -4;
        }

        j(int i, long j, long j2) {
            super(i, j, j2);
        }

        j(Parcel parcel) {
            super(parcel);
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot.a
        public final MessageSnapshot Dc() {
            return new f(this);
        }
    }

    public static class e extends f {
        @Override // com.kwad.framework.filedownloader.message.d.f, com.kwad.framework.filedownloader.message.c
        public final byte AT() {
            return (byte) -2;
        }

        e(int i, long j, long j2) {
            super(i, j, j2);
        }
    }
}

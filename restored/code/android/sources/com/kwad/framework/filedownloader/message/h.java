package com.kwad.framework.filedownloader.message;

import android.os.Parcel;

/* JADX INFO: loaded from: classes3.dex */
public abstract class h extends MessageSnapshot {
    h(int i2) {
        super(i2);
        this.aCz = false;
    }

    h(Parcel parcel) {
        super(parcel);
    }

    @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
    public final long CY() {
        return CX();
    }

    @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
    public final long Da() {
        return CW();
    }

    public static class f extends h {
        private final int aCJ;
        private final int aCK;

        public byte AT() {
            return (byte) 1;
        }

        f(f fVar) {
            this(fVar.getId(), fVar.CW(), fVar.CX());
        }

        f(int i, int i2, int i3) {
            super(i);
            this.aCK = i2;
            this.aCJ = i3;
        }

        f(Parcel parcel) {
            super(parcel);
            this.aCK = parcel.readInt();
            this.aCJ = parcel.readInt();
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public void writeToParcel(Parcel parcel, int i) {
            super.writeToParcel(parcel, i);
            parcel.writeInt(this.aCK);
            parcel.writeInt(this.aCJ);
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final int CW() {
            return this.aCK;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final int CX() {
            return this.aCJ;
        }
    }

    public static class c extends h {
        private final String aAT;
        private final int aCJ;
        private final boolean aCw;
        private final String fileName;

        @Override // com.kwad.framework.filedownloader.message.c
        public final byte AT() {
            return (byte) 2;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public final int describeContents() {
            return 0;
        }

        c(int i, boolean z, int i2, String str, String str2) {
            super(i);
            this.aCw = z;
            this.aCJ = i2;
            this.aAT = str;
            this.fileName = str2;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public final void writeToParcel(Parcel parcel, int i) {
            super.writeToParcel(parcel, i);
            parcel.writeByte(this.aCw ? (byte) 1 : (byte) 0);
            parcel.writeInt(this.aCJ);
            parcel.writeString(this.aAT);
            parcel.writeString(this.fileName);
        }

        c(Parcel parcel) {
            super(parcel);
            this.aCw = parcel.readByte() != 0;
            this.aCJ = parcel.readInt();
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
        public final int CX() {
            return this.aCJ;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final String getEtag() {
            return this.aAT;
        }
    }

    public static class g extends h {
        private final int aCK;

        @Override // com.kwad.framework.filedownloader.message.c
        public final byte AT() {
            return (byte) 3;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public final int describeContents() {
            return 0;
        }

        g(int i, int i2) {
            super(i);
            this.aCK = i2;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final int CW() {
            return this.aCK;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public final void writeToParcel(Parcel parcel, int i) {
            super.writeToParcel(parcel, i);
            parcel.writeInt(this.aCK);
        }

        g(Parcel parcel) {
            super(parcel);
            this.aCK = parcel.readInt();
        }
    }

    public static class a extends b implements com.kwad.framework.filedownloader.message.b {
        a(int i, boolean z, int i2) {
            super(i, true, i2);
        }
    }

    public static class b extends h {
        private final int aCJ;
        private final boolean aCv;

        @Override // com.kwad.framework.filedownloader.message.c
        public final byte AT() {
            return (byte) -3;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public int describeContents() {
            return 0;
        }

        b(int i, boolean z, int i2) {
            super(i);
            this.aCv = z;
            this.aCJ = i2;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public void writeToParcel(Parcel parcel, int i) {
            super.writeToParcel(parcel, i);
            parcel.writeByte(this.aCv ? (byte) 1 : (byte) 0);
            parcel.writeInt(this.aCJ);
        }

        b(Parcel parcel) {
            super(parcel);
            this.aCv = parcel.readByte() != 0;
            this.aCJ = parcel.readInt();
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final int CX() {
            return this.aCJ;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final boolean CZ() {
            return this.aCv;
        }
    }

    public static class d extends h {
        private final int aCK;
        private final Throwable aCy;

        @Override // com.kwad.framework.filedownloader.message.c
        public byte AT() {
            return (byte) -1;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public int describeContents() {
            return 0;
        }

        d(int i, int i2, Throwable th) {
            super(i);
            this.aCK = i2;
            this.aCy = th;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final int CW() {
            return this.aCK;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final Throwable Db() {
            return this.aCy;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public void writeToParcel(Parcel parcel, int i) {
            super.writeToParcel(parcel, i);
            parcel.writeInt(this.aCK);
            parcel.writeSerializable(this.aCy);
        }

        d(Parcel parcel) {
            super(parcel);
            this.aCK = parcel.readInt();
            this.aCy = (Throwable) parcel.readSerializable();
        }
    }

    /* JADX INFO: renamed from: com.kwad.framework.filedownloader.message.h$h, reason: collision with other inner class name */
    public static class C0490h extends d {
        private final int aCe;

        @Override // com.kwad.framework.filedownloader.message.h.d, com.kwad.framework.filedownloader.message.c
        public final byte AT() {
            return (byte) 5;
        }

        @Override // com.kwad.framework.filedownloader.message.h.d, com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public final int describeContents() {
            return 0;
        }

        C0490h(int i, int i2, Throwable th, int i3) {
            super(i, i2, th);
            this.aCe = i3;
        }

        @Override // com.kwad.framework.filedownloader.message.MessageSnapshot
        public final int AX() {
            return this.aCe;
        }

        @Override // com.kwad.framework.filedownloader.message.h.d, com.kwad.framework.filedownloader.message.MessageSnapshot, android.os.Parcelable
        public final void writeToParcel(Parcel parcel, int i) {
            super.writeToParcel(parcel, i);
            parcel.writeInt(this.aCe);
        }

        C0490h(Parcel parcel) {
            super(parcel);
            this.aCe = parcel.readInt();
        }
    }

    public static class i extends j implements com.kwad.framework.filedownloader.message.b {
        i(int i, int i2, int i3) {
            super(i, i2, i3);
        }
    }

    public static class j extends f implements MessageSnapshot.a {
        @Override // com.kwad.framework.filedownloader.message.h.f, com.kwad.framework.filedownloader.message.c
        public final byte AT() {
            return (byte) -4;
        }

        j(int i, int i2, int i3) {
            super(i, i2, i3);
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
        @Override // com.kwad.framework.filedownloader.message.h.f, com.kwad.framework.filedownloader.message.c
        public final byte AT() {
            return (byte) -2;
        }

        e(int i, int i2, int i3) {
            super(i, i2, i3);
        }
    }
}

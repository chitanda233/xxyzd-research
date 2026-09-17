package com.kwad.components.core.page.widget.a;

import android.os.Parcel;
import android.os.Parcelable;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class e implements Parcelable {
    public static final Parcelable.Creator<e> CREATOR = new Parcelable.Creator<e>() { // from class: com.kwad.components.core.page.widget.a.e.1
        @Override // android.os.Parcelable.Creator
        public final /* synthetic */ e createFromParcel(Parcel parcel) {
            return b(parcel);
        }

        @Override // android.os.Parcelable.Creator
        public final /* synthetic */ e[] newArray(int i) {
            return bA(i);
        }

        private static e b(Parcel parcel) {
            return new e(parcel);
        }

        private static e[] bA(int i) {
            return new e[i];
        }
    };
    public float ahA;
    public float ahB;
    public float ahC;
    public int ahD;
    public boolean ahE;
    public boolean ahF;
    public boolean ahG;
    public int ahH;
    public boolean ahI = true;
    public c ahJ;
    public Map<String, String> ahK;
    public boolean ahz;

    @Override // android.os.Parcelable
    public final int describeContents() {
        return 0;
    }

    public final float vz() {
        float f = this.ahB;
        if (f > 0.0f) {
            return f;
        }
        return -1.0f;
    }

    @Override // android.os.Parcelable
    public final void writeToParcel(Parcel parcel, int i) {
        parcel.writeByte(this.ahz ? (byte) 1 : (byte) 0);
        parcel.writeFloat(this.ahA);
        parcel.writeFloat(this.ahB);
        parcel.writeFloat(this.ahC);
        parcel.writeInt(this.ahD);
        parcel.writeByte(this.ahE ? (byte) 1 : (byte) 0);
        parcel.writeByte(this.ahF ? (byte) 1 : (byte) 0);
    }

    public e() {
    }

    protected e(Parcel parcel) {
        this.ahz = parcel.readByte() != 0;
        this.ahA = parcel.readFloat();
        this.ahB = parcel.readFloat();
        this.ahC = parcel.readFloat();
        this.ahD = parcel.readInt();
        this.ahE = parcel.readByte() != 0;
        this.ahF = parcel.readByte() != 0;
    }
}

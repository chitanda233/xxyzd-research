package com.tencent.turingfd.sdk.ams.ad;

import android.os.Parcel;
import android.os.Parcelable;

/* JADX INFO: loaded from: classes4.dex */
public final class Sorgo implements Parcelable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final int f3892a;
    public final byte[] b;
    public final int c;

    public Sorgo(Parcel parcel) {
        this.f3892a = parcel.readInt();
        this.b = parcel.createByteArray();
        this.c = parcel.readInt();
    }

    @Override // android.os.Parcelable
    public final int describeContents() {
        return 0;
    }

    @Override // android.os.Parcelable
    public final void writeToParcel(Parcel parcel, int i) {
        parcel.writeInt(this.f3892a);
        parcel.writeByteArray(this.b);
        parcel.writeInt(this.c);
    }
}

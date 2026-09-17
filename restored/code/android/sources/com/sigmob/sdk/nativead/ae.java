package com.sigmob.sdk.nativead;

import android.os.Parcel;
import android.os.Parcelable;

/* JADX INFO: loaded from: classes4.dex */
public class ae implements Parcelable {
    public static final Parcelable.Creator<ae> CREATOR = new Parcelable.Creator<ae>() { // from class: com.sigmob.sdk.nativead.ae.1
        @Override // android.os.Parcelable.Creator
        /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
        public ae createFromParcel(Parcel in) {
            return new ae(in);
        }

        @Override // android.os.Parcelable.Creator
        /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
        public ae[] newArray(int size) {
            return new ae[size];
        }
    };

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private int f3568a;
    private int b;
    private int c;
    private int d;

    public ae() {
    }

    protected ae(Parcel in) {
        this.f3568a = in.readInt();
        this.b = in.readInt();
        this.c = in.readInt();
        this.d = in.readInt();
    }

    public int a() {
        return this.f3568a;
    }

    public void a(int x) {
        this.f3568a = x;
    }

    public int b() {
        return this.b;
    }

    public void b(int y) {
        this.b = y;
    }

    public int c() {
        return this.c;
    }

    public void c(int width) {
        this.c = width;
    }

    public int d() {
        return this.d;
    }

    public void d(int height) {
        this.d = height;
    }

    @Override // android.os.Parcelable
    public int describeContents() {
        return 0;
    }

    @Override // android.os.Parcelable
    public void writeToParcel(Parcel dest, int flags) {
        dest.writeInt(this.f3568a);
        dest.writeInt(this.b);
        dest.writeInt(this.c);
        dest.writeInt(this.d);
    }
}

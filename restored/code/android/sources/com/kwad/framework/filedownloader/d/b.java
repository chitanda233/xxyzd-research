package com.kwad.framework.filedownloader.d;

import android.os.Parcel;
import android.os.Parcelable;
import com.kwad.sdk.utils.az;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class b implements Parcelable {
    public static final Parcelable.Creator<b> CREATOR = new Parcelable.Creator<b>() { // from class: com.kwad.framework.filedownloader.d.b.1
        @Override // android.os.Parcelable.Creator
        public final /* synthetic */ b createFromParcel(Parcel parcel) {
            return d(parcel);
        }

        @Override // android.os.Parcelable.Creator
        public final /* synthetic */ b[] newArray(int i) {
            return cK(i);
        }

        private static b d(Parcel parcel) {
            return new b(parcel);
        }

        private static b[] cK(int i) {
            return new b[i];
        }
    };
    private HashMap<String, List<String>> aCL;

    @Override // android.os.Parcelable
    public final int describeContents() {
        return 0;
    }

    public final void z(String str, String str2) {
        az.hX(str);
        az.hX(str2);
        if (this.aCL == null) {
            this.aCL = new HashMap<>();
        }
        List<String> arrayList = this.aCL.get(str);
        if (arrayList == null) {
            arrayList = new ArrayList<>();
            this.aCL.put(str, arrayList);
        }
        if (arrayList.contains(str2)) {
            return;
        }
        arrayList.add(str2);
    }

    public final void cd(String str) {
        HashMap<String, List<String>> map = this.aCL;
        if (map == null) {
            return;
        }
        map.remove(str);
    }

    @Override // android.os.Parcelable
    public final void writeToParcel(Parcel parcel, int i) {
        parcel.writeMap(this.aCL);
    }

    public final HashMap<String, List<String>> Di() {
        return this.aCL;
    }

    public b() {
    }

    protected b(Parcel parcel) {
        this.aCL = parcel.readHashMap(String.class.getClassLoader());
    }

    public final String toString() {
        return this.aCL.toString();
    }
}

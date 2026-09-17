package com.unity3d.player;

import android.app.Activity;
import android.content.Context;
import android.os.Looper;
import com.google.android.play.core.assetpacks.AssetPackLocation;
import com.google.android.play.core.assetpacks.AssetPackManager;
import com.google.android.play.core.assetpacks.AssetPackManagerFactory;
import java.util.Arrays;
import java.util.Collections;
import java.util.HashSet;

/* JADX INFO: renamed from: com.unity3d.player.n, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class C0727n {
    private static C0727n d;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private AssetPackManager f4057a;
    private HashSet b;
    private Object c;

    private C0727n(Context context) {
        if (d != null) {
            throw new RuntimeException("AssetPackManagerWrapper should be created only once. Use getInstance() instead.");
        }
        this.f4057a = AssetPackManagerFactory.getInstance(context);
        this.b = new HashSet();
    }

    public static C0727n a(Context context) {
        if (d == null) {
            d = new C0727n(context);
        }
        return d;
    }

    public final Object a(IAssetPackManagerDownloadStatusCallback iAssetPackManagerDownloadStatusCallback) {
        C0715h c0715h = new C0715h(this, iAssetPackManagerDownloadStatusCallback, Looper.myLooper());
        this.f4057a.registerListener(c0715h);
        return c0715h;
    }

    public final String a(String str) {
        AssetPackLocation packLocation = this.f4057a.getPackLocation(str);
        return packLocation == null ? "" : packLocation.assetsPath();
    }

    public final void a(Activity activity, IAssetPackManagerMobileDataConfirmationCallback iAssetPackManagerMobileDataConfirmationCallback) {
        this.f4057a.showCellularDataConfirmation(activity).addOnSuccessListener(new C0719j(iAssetPackManagerMobileDataConfirmationCallback));
    }

    public final void a(Object obj) {
        if (obj instanceof C0715h) {
            this.f4057a.unregisterListener((C0715h) obj);
        }
    }

    public final void a(String[] strArr) {
        this.f4057a.cancel(Arrays.asList(strArr));
    }

    public final void a(String[] strArr, IAssetPackManagerDownloadStatusCallback iAssetPackManagerDownloadStatusCallback) {
        for (String str : strArr) {
            this.f4057a.getPackStates(Collections.singletonList(str)).addOnCompleteListener(new C0721k(str, iAssetPackManagerDownloadStatusCallback));
        }
    }

    public final void a(String[] strArr, IAssetPackManagerStatusQueryCallback iAssetPackManagerStatusQueryCallback) {
        this.f4057a.getPackStates(Arrays.asList(strArr)).addOnCompleteListener(new C0725m(strArr, iAssetPackManagerStatusQueryCallback));
    }

    public final void b(String str) {
        this.f4057a.removePack(str);
    }
}

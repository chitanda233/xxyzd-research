package com.onevcat.uniwebview;

import android.graphics.Bitmap;
import android.graphics.Rect;
import com.bykv.vk.component.ttvideo.mediakit.medialoader.AVMDLDataLoader;
import java.io.File;
import java.io.FileOutputStream;
import java.util.UUID;
import kotlin.Unit;
import kotlin.jvm.functions.Function1;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: renamed from: com.onevcat.uniwebview.m0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0658m0 extends Lambda implements Function1 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ String f2912a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public C0658m0(String str) {
        super(1);
        this.f2912a = str;
    }

    @Override // kotlin.jvm.functions.Function1
    public final Object invoke(Object obj) {
        Y1 y1;
        String absolutePath;
        N it = (N) obj;
        Intrinsics.checkNotNullParameter(it, "it");
        String str = this.f2912a;
        if (it.e.getHeight() <= 0 || it.e.getWidth() <= 0) {
            y1 = new Y1("", String.valueOf(AVMDLDataLoader.AVMDLErrorIsTooManyTask), "", null);
        } else {
            Bitmap bitmapA = it.a((Rect) null);
            File cacheDir = it.f2849a.getCacheDir();
            if (str == null || str.length() == 0) {
                str = UUID.randomUUID() + ".png";
            }
            try {
                File file = new File(cacheDir, str);
                FileOutputStream fileOutputStream = new FileOutputStream(file);
                bitmapA.compress(Bitmap.CompressFormat.PNG, 100, fileOutputStream);
                fileOutputStream.flush();
                fileOutputStream.close();
                C0654l c0654l = C0654l.b;
                String message = "Capture Snapshot done. File written in: " + file;
                c0654l.getClass();
                Intrinsics.checkNotNullParameter(message, "message");
                c0654l.a(EnumC0651k.INFO, message);
                absolutePath = file.getAbsolutePath();
            } catch (Exception e) {
                C0654l c0654l2 = C0654l.b;
                String message2 = "Error during save snapshot image: " + e;
                c0654l2.getClass();
                Intrinsics.checkNotNullParameter(message2, "message");
                c0654l2.a(EnumC0651k.CRITICAL, message2);
                absolutePath = null;
            }
            y1 = absolutePath != null ? new Y1("", String.valueOf(0), absolutePath, null) : new Y1("", String.valueOf(-1000), "", null);
        }
        it.c.a(it.b, d2.CaptureSnapshotFinished, y1);
        return Unit.INSTANCE;
    }
}

package com.onevcat.uniwebview;

import android.app.Activity;
import android.app.AlertDialog;
import android.app.DownloadManager;
import android.content.DialogInterface;
import android.content.IntentFilter;
import android.net.Uri;
import android.os.Build;
import android.os.Environment;
import android.webkit.CookieManager;
import android.webkit.MimeTypeMap;
import android.webkit.URLUtil;
import android.widget.EditText;
import android.widget.Toast;
import java.io.File;
import java.util.HashMap;
import java.util.Map;
import kotlin.io.FilesKt;
import kotlin.jvm.functions.Function0;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.StringCompanionObject;
import kotlin.text.StringsKt;

/* JADX INFO: loaded from: classes3.dex */
public final class W {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final Activity f2868a;
    public final String b;
    public final c2 c;
    public final Function0 d;
    public boolean e;
    public final HashMap f;
    public final V g;

    public W(Activity activity, String name, c2 messageSender, C0678t customizeHeaders) {
        Intrinsics.checkNotNullParameter(activity, "activity");
        Intrinsics.checkNotNullParameter(name, "name");
        Intrinsics.checkNotNullParameter(messageSender, "messageSender");
        Intrinsics.checkNotNullParameter(customizeHeaders, "customizeHeaders");
        this.f2868a = activity;
        this.b = name;
        this.c = messageSender;
        this.d = customizeHeaders;
        this.e = true;
        this.f = new HashMap();
        this.g = new V(this);
    }

    public final void a(String url, String str, String str2, boolean z) {
        Intrinsics.checkNotNullParameter(url, "url");
        Intrinsics.checkNotNullParameter(url, "url");
        C0639g c0639g = null;
        if (StringsKt.startsWith$default(url, "data:", false, 2, (Object) null)) {
            try {
                C0657m c0657mA = U.a(url);
                if (c0657mA != null) {
                    C0642h c0642h = new C0642h(url, c0657mA.b);
                    if (str2 == null && (str2 = c0657mA.f2911a) == null) {
                        str2 = "";
                    }
                    String extensionFromMimeType = MimeTypeMap.getSingleton().getExtensionFromMimeType(str2);
                    c0639g = new C0639g(c0642h, extensionFromMimeType == null ? AbstractC0666p.a(StringCompanionObject.INSTANCE) : AbstractC0666p.a(StringCompanionObject.INSTANCE) + '.' + extensionFromMimeType, z);
                }
            } catch (Exception e) {
                C0654l c0654l = C0654l.b;
                String message = "Failed to parse data url: " + url + ". Error: " + e;
                c0654l.getClass();
                Intrinsics.checkNotNullParameter(message, "message");
                c0654l.a(EnumC0651k.CRITICAL, message);
            }
        } else if (URLUtil.isValidUrl(url)) {
            String fileName = URLUtil.guessFileName(url, str, str2);
            C0645i c0645i = new C0645i(url);
            Intrinsics.checkNotNullExpressionValue(fileName, "fileName");
            c0639g = new C0639g(c0645i, fileName, z);
        }
        if (c0639g != null) {
            a(c0639g);
        } else {
            Activity activity = this.f2868a;
            Toast.makeText(activity, activity.getResources().getString(R.string.INVALID_URL), 1).show();
        }
    }

    public final void b(C0639g c0639g) {
        AbstractC0648j abstractC0648j = c0639g.f2894a;
        if (abstractC0648j instanceof C0645i) {
            DownloadManager.Request request = new DownloadManager.Request(Uri.parse(c0639g.a()));
            request.allowScanningByMediaScanner();
            request.setNotificationVisibility(1);
            request.setDescription(c0639g.b);
            request.setTitle(c0639g.b);
            request.setDestinationInExternalFilesDir(this.f2868a, Environment.DIRECTORY_DOWNLOADS, c0639g.b);
            request.addRequestHeader(com.sigmob.sdk.base.e.f3213a, CookieManager.getInstance().getCookie(c0639g.a()));
            for (Map.Entry entry : ((Map) this.d.invoke()).entrySet()) {
                request.addRequestHeader((String) entry.getKey(), (String) entry.getValue());
            }
            Object systemService = this.f2868a.getSystemService("download");
            if (systemService instanceof DownloadManager) {
                this.f.put(Long.valueOf(((DownloadManager) systemService).enqueue(request)), c0639g);
                Activity activity = this.f2868a;
                Toast.makeText(activity, activity.getResources().getString(R.string.DOWNLOAD_STARTED), 1).show();
                if (c0639g.c) {
                    this.c.a(this.b, d2.FileDownloadStarted, new Y1(c0639g.a(), "0", c0639g.b, null));
                    return;
                }
                return;
            }
            return;
        }
        if (abstractC0648j instanceof C0642h) {
            C0642h c0642h = (C0642h) abstractC0648j;
            String strA = c0639g.a();
            if (c0639g.c) {
                this.c.a(this.b, d2.FileDownloadStarted, new Y1(strA, "0", c0639g.b, null));
            }
            try {
                File file = new File(this.f2868a.getExternalFilesDir(Environment.DIRECTORY_DOWNLOADS), c0639g.b);
                FilesKt.writeBytes(file, c0642h.b);
                if (c0639g.c) {
                    String absolutePath = file.getAbsolutePath();
                    Intrinsics.checkNotNullExpressionValue(absolutePath, "file.absolutePath");
                    this.c.a(this.b, d2.FileDownloadFinished, new Y1(strA, "0", absolutePath, null));
                }
            } catch (Exception e) {
                C0654l c0654l = C0654l.b;
                String message = "Failed to download base64 data: " + strA + ". Error: " + e;
                c0654l.getClass();
                Intrinsics.checkNotNullParameter(message, "message");
                c0654l.a(EnumC0651k.CRITICAL, message);
            }
        }
    }

    public final void a() {
        if (Build.VERSION.SDK_INT >= 33) {
            this.f2868a.registerReceiver(this.g, new IntentFilter("android.intent.action.DOWNLOAD_COMPLETE"), 2);
        } else {
            this.f2868a.registerReceiver(this.g, new IntentFilter("android.intent.action.DOWNLOAD_COMPLETE"));
        }
    }

    public final void a(final C0639g c0639g) {
        if (!this.e) {
            b(c0639g);
            return;
        }
        final EditText editText = new EditText(this.f2868a);
        editText.setSingleLine();
        editText.setText(c0639g.b);
        AlertDialog.Builder cancelable = new AlertDialog.Builder(this.f2868a).setTitle(c0639g.a()).setMessage(this.f2868a.getResources().getString(R.string.DOWNLOAD_DESCRIPTION)).setIcon(android.R.drawable.ic_dialog_info).setCancelable(true);
        Intrinsics.checkNotNullExpressionValue(cancelable, "Builder(activity)\n      …     .setCancelable(true)");
        AbstractC0621a.a(cancelable, editText).setPositiveButton(android.R.string.ok, new DialogInterface.OnClickListener() { // from class: com.onevcat.uniwebview.W$$ExternalSyntheticLambda0
            @Override // android.content.DialogInterface.OnClickListener
            public final void onClick(DialogInterface dialogInterface, int i) {
                W.a(editText, c0639g, this, dialogInterface, i);
            }
        }).setNegativeButton(android.R.string.cancel, new DialogInterface.OnClickListener() { // from class: com.onevcat.uniwebview.W$$ExternalSyntheticLambda1
            @Override // android.content.DialogInterface.OnClickListener
            public final void onClick(DialogInterface dialogInterface, int i) {
                W.a(dialogInterface, i);
            }
        }).create().show();
    }

    public static final void a(EditText input, C0639g task, W this$0, DialogInterface dialogInterface, int i) {
        Intrinsics.checkNotNullParameter(input, "$input");
        Intrinsics.checkNotNullParameter(task, "$task");
        Intrinsics.checkNotNullParameter(this$0, "this$0");
        String string = input.getText().toString();
        dialogInterface.dismiss();
        task.getClass();
        Intrinsics.checkNotNullParameter(string, "<set-?>");
        task.b = string;
        this$0.b(task);
    }

    public static final void a(DialogInterface dialogInterface, int i) {
        dialogInterface.dismiss();
    }
}

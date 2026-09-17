package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.drawable.BitmapDrawable;
import android.media.MediaMetadataRetriever;
import android.media.MediaPlayer;
import android.net.Uri;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import java.util.HashMap;

/* JADX INFO: loaded from: classes2.dex */
public abstract class w0 {

    class a implements MediaPlayer.OnCompletionListener {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ C0615u f2029a;

        /* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.w0$a$a, reason: collision with other inner class name */
        class C0342a implements MediaPlayer.OnInfoListener {
            C0342a() {
            }

            @Override // android.media.MediaPlayer.OnInfoListener
            public boolean onInfo(MediaPlayer mediaPlayer, int i, int i2) {
                return false;
            }
        }

        a(C0615u c0615u) {
            this.f2029a = c0615u;
        }

        @Override // android.media.MediaPlayer.OnCompletionListener
        public void onCompletion(MediaPlayer mediaPlayer) {
            this.f2029a.start();
            mediaPlayer.setOnInfoListener(new C0342a());
        }
    }

    class b implements MediaPlayer.OnPreparedListener {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ C0615u f2031a;

        class a implements MediaPlayer.OnInfoListener {
            a() {
            }

            @Override // android.media.MediaPlayer.OnInfoListener
            public boolean onInfo(MediaPlayer mediaPlayer, int i, int i2) {
                if (i != 3) {
                    return true;
                }
                b.this.f2031a.setBackgroundColor(0);
                return true;
            }
        }

        b(C0615u c0615u) {
            this.f2031a = c0615u;
        }

        @Override // android.media.MediaPlayer.OnPreparedListener
        public void onPrepared(MediaPlayer mediaPlayer) {
            mediaPlayer.setOnInfoListener(new a());
        }
    }

    class c implements MediaPlayer.OnErrorListener {
        c() {
        }

        @Override // android.media.MediaPlayer.OnErrorListener
        public boolean onError(MediaPlayer mediaPlayer, int i, int i2) {
            return true;
        }
    }

    public static void a(Context context, View view, int i, int i2) {
        try {
            ViewGroup.LayoutParams layoutParams = view.getLayoutParams();
            layoutParams.height = AbstractC0597c.a(context, i2);
            layoutParams.width = AbstractC0597c.a(context, i);
            view.setLayoutParams(layoutParams);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static void b(Context context, View view, int i, int i2, int i3, int i4, int i5) {
        ViewGroup.LayoutParams layoutParams = view.getLayoutParams();
        layoutParams.width = -1;
        layoutParams.height = -2;
        ViewGroup.MarginLayoutParams marginLayoutParams = new ViewGroup.MarginLayoutParams(layoutParams);
        int iA = AbstractC0597c.a(context, i2);
        int iA2 = AbstractC0597c.a(context, i);
        int iA3 = AbstractC0597c.a(context, i3);
        if (i == -1 && i3 == -1) {
            marginLayoutParams.setMargins(0, iA, 0, 0);
        } else if (i == -1 && i3 != -1) {
            marginLayoutParams.setMargins(0, 0, 0, iA3);
        } else if (i != -1 && i3 == -1) {
            marginLayoutParams.setMargins(iA2, iA, 0, 0);
        } else if (i != -1 && i3 != -1) {
            marginLayoutParams.setMargins(iA2, 0, 0, iA3);
        }
        RelativeLayout.LayoutParams layoutParams2 = new RelativeLayout.LayoutParams(marginLayoutParams);
        if (i5 != -1) {
            layoutParams2.height = AbstractC0597c.a(context, i5);
        }
        if (i4 == -1) {
            layoutParams2.leftMargin = AbstractC0597c.a(context, 47.0f);
            layoutParams2.rightMargin = AbstractC0597c.a(context, 47.0f);
        } else {
            layoutParams2.width = AbstractC0597c.a(context, i4);
        }
        if (i == -1 && i3 == -1) {
            layoutParams2.addRule(10);
            layoutParams2.addRule(14);
        } else if (i == -1 && i3 != -1) {
            layoutParams2.addRule(12);
            layoutParams2.addRule(14);
        } else if (i != -1 && i3 == -1) {
            layoutParams2.addRule(10);
            layoutParams2.addRule(9);
        } else if (i != -1 && i3 != -1) {
            layoutParams2.addRule(12);
            layoutParams2.addRule(9);
        }
        view.setLayoutParams(layoutParams2);
    }

    public static void a(Context context, View view, int i, int i2, int i3, int i4, int i5) {
        ViewGroup.LayoutParams layoutParams = view.getLayoutParams();
        layoutParams.width = -2;
        layoutParams.height = -2;
        ViewGroup.MarginLayoutParams marginLayoutParams = new ViewGroup.MarginLayoutParams(layoutParams);
        int iA = AbstractC0597c.a(context, i2);
        int iA2 = AbstractC0597c.a(context, i);
        int iA3 = AbstractC0597c.a(context, i3);
        if (i == -1 && i3 == -1) {
            marginLayoutParams.setMargins(0, iA, 0, 0);
        } else if (i == -1 && i3 != -1) {
            marginLayoutParams.setMargins(0, 0, 0, iA3);
        } else if (i != -1 && i3 == -1) {
            marginLayoutParams.setMargins(iA2, iA, 0, 0);
        } else if (i != -1 && i3 != -1) {
            marginLayoutParams.setMargins(iA2, 0, 0, iA3);
        }
        RelativeLayout.LayoutParams layoutParams2 = new RelativeLayout.LayoutParams(marginLayoutParams);
        if (i5 != -1) {
            layoutParams2.height = AbstractC0597c.a(context, i5);
        }
        if (i4 != -1) {
            layoutParams2.width = AbstractC0597c.a(context, i4);
        }
        if (i == -1 && i3 == -1) {
            layoutParams2.addRule(10);
            layoutParams2.addRule(14);
        } else if (i == -1 && i3 != -1) {
            layoutParams2.addRule(12);
            layoutParams2.addRule(14);
        } else if (i != -1 && i3 == -1) {
            layoutParams2.addRule(10);
            layoutParams2.addRule(9);
        } else if (i != -1 && i3 != -1) {
            layoutParams2.addRule(12);
            layoutParams2.addRule(9);
        }
        view.setLayoutParams(layoutParams2);
    }

    public static void a(Context context, View view, int i, int i2, int i3, int i4, int i5, ImageView imageView) {
        ViewGroup.LayoutParams layoutParams = view.getLayoutParams();
        layoutParams.width = -2;
        layoutParams.height = -2;
        ViewGroup.MarginLayoutParams marginLayoutParams = new ViewGroup.MarginLayoutParams(layoutParams);
        int iA = AbstractC0597c.a(context, i2);
        int iA2 = AbstractC0597c.a(context, i);
        int iA3 = AbstractC0597c.a(context, i3);
        if (i2 == -1 && i3 == -1) {
            marginLayoutParams.setMargins(iA2, 0, 0, 0);
        } else if (i2 == -1 && i3 != -1) {
            marginLayoutParams.setMargins(0, 0, iA3, 0);
        } else if (i2 != -1 && i3 == -1) {
            marginLayoutParams.setMargins(iA2, iA, 0, 0);
        } else if (i2 != -1 && i3 != -1) {
            marginLayoutParams.setMargins(0, iA, iA3, 0);
        }
        RelativeLayout.LayoutParams layoutParams2 = new RelativeLayout.LayoutParams(marginLayoutParams);
        ViewGroup.LayoutParams layoutParams3 = imageView.getLayoutParams();
        if (i5 != -1) {
            layoutParams3.height = AbstractC0597c.a(context, i5);
        } else {
            layoutParams3.height = -2;
        }
        if (i4 == -1) {
            layoutParams3.width = -2;
        } else {
            layoutParams3.width = AbstractC0597c.a(context, i4);
        }
        imageView.setLayoutParams(layoutParams3);
        if (i2 == -1 && i3 == -1) {
            layoutParams2.addRule(9);
            layoutParams2.addRule(15);
        } else if (i2 == -1 && i3 != -1) {
            layoutParams2.addRule(11);
            layoutParams2.addRule(15);
        } else if (i2 != -1 && i3 == -1) {
            layoutParams2.addRule(10);
            layoutParams2.addRule(9);
        } else if (i2 != -1 && i3 != -1) {
            layoutParams2.addRule(10);
            layoutParams2.addRule(11);
        }
        view.setLayoutParams(layoutParams2);
    }

    public static void a(Context context, View view, int i, int i2, int i3) {
        ViewGroup.LayoutParams layoutParams = view.getLayoutParams();
        layoutParams.width = -2;
        layoutParams.height = -2;
        ViewGroup.MarginLayoutParams marginLayoutParams = new ViewGroup.MarginLayoutParams(view.getLayoutParams());
        int iA = AbstractC0597c.a(context, i2);
        int iA2 = AbstractC0597c.a(context, i);
        int iA3 = AbstractC0597c.a(context, i3);
        if (i == -1 && i3 == -1) {
            marginLayoutParams.setMargins(0, iA, 0, 0);
        } else if (i == -1 && i3 != -1) {
            marginLayoutParams.setMargins(0, 0, 0, iA3);
        } else if (i != -1 && i3 == -1) {
            marginLayoutParams.setMargins(iA2, iA, 0, 0);
        } else if (i != -1 && i3 != -1) {
            marginLayoutParams.setMargins(iA2, 0, 0, iA3);
        }
        RelativeLayout.LayoutParams layoutParams2 = new RelativeLayout.LayoutParams(marginLayoutParams);
        if (i == -1 && i3 == -1) {
            layoutParams2.addRule(10);
            layoutParams2.addRule(14);
        } else if (i == -1 && i3 != -1) {
            layoutParams2.addRule(12);
            layoutParams2.addRule(14);
        } else if (i != -1 && i3 == -1) {
            layoutParams2.addRule(10);
            layoutParams2.addRule(9);
        } else if (i != -1 && i3 != -1) {
            layoutParams2.addRule(12);
            layoutParams2.addRule(9);
        }
        view.setLayoutParams(layoutParams2);
    }

    public static void a(Context context, RelativeLayout relativeLayout, int i, int i2, int i3, int i4, int i5, int i6) {
        try {
            ViewGroup.MarginLayoutParams marginLayoutParams = new ViewGroup.MarginLayoutParams((ViewGroup.MarginLayoutParams) relativeLayout.getLayoutParams());
            int iA = AbstractC0597c.a(context, i);
            int iA2 = AbstractC0597c.a(context, i2);
            int iA3 = AbstractC0597c.a(context, i3);
            int iA4 = AbstractC0597c.a(context, i4);
            int iA5 = AbstractC0597c.a(context, i5);
            int iA6 = AbstractC0597c.a(context, i6);
            relativeLayout.setPadding(iA, iA2, iA3, iA4);
            if (i5 != -1 && i6 != -1) {
                marginLayoutParams.setMargins((-iA) + iA5, (-iA2) + iA6, 0, 0);
            } else if (i5 != -1 && i6 == -1) {
                marginLayoutParams.setMargins((-iA) + iA5, 0, 0, 0);
            } else if (i5 == -1 && i6 != -1) {
                marginLayoutParams.setMargins(0, (-iA2) + iA6, 0, 0);
            } else {
                marginLayoutParams.setMargins(0, 0, 0, 0);
            }
            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(marginLayoutParams);
            if (i6 != -1) {
                layoutParams.addRule(10);
            } else {
                layoutParams.addRule(15);
            }
            layoutParams.addRule(9);
            relativeLayout.setLayoutParams(layoutParams);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static void a(C0615u c0615u, Context context, String str) {
        Bitmap frameAtTime = null;
        try {
            try {
                try {
                    Uri uri = Uri.parse(str);
                    c0615u.setVideoURI(uri);
                    c0615u.setVisibility(0);
                    MediaMetadataRetriever mediaMetadataRetriever = new MediaMetadataRetriever();
                    try {
                        try {
                            if (!str.startsWith("http://") && !str.startsWith("https://")) {
                                mediaMetadataRetriever.setDataSource(context, uri);
                            } else {
                                mediaMetadataRetriever.setDataSource(str, new HashMap());
                            }
                            frameAtTime = mediaMetadataRetriever.getFrameAtTime();
                            mediaMetadataRetriever.release();
                        } catch (Exception e) {
                            e.printStackTrace();
                            mediaMetadataRetriever.release();
                        }
                        c0615u.setBackground(new BitmapDrawable(context.getResources(), frameAtTime));
                        c0615u.start();
                        c0615u.setOnCompletionListener(new a(c0615u));
                        c0615u.setOnPreparedListener(new b(c0615u));
                        c0615u.setOnErrorListener(new c());
                        if (frameAtTime != null) {
                            try {
                                frameAtTime.isRecycled();
                            } catch (Exception e2) {
                                Q.d("ExceptionShanYanLogger", "startBgVideo Exception_e=", e2);
                                e2.printStackTrace();
                            }
                        }
                    } catch (Throwable th) {
                        try {
                            mediaMetadataRetriever.release();
                        } catch (Exception e3) {
                            e3.printStackTrace();
                        }
                        throw th;
                    }
                } catch (Exception e4) {
                    e4.printStackTrace();
                }
            } catch (Exception e5) {
                e5.printStackTrace();
                if (0 != 0) {
                    try {
                        frameAtTime.isRecycled();
                    } catch (Exception e6) {
                        Q.d("ExceptionShanYanLogger", "startBgVideo Exception_e=", e6);
                        e6.printStackTrace();
                    }
                }
            }
        } catch (Throwable th2) {
            if (0 != 0) {
                try {
                    frameAtTime.isRecycled();
                } catch (Exception e7) {
                    Q.d("ExceptionShanYanLogger", "startBgVideo Exception_e=", e7);
                    e7.printStackTrace();
                }
            }
            throw th2;
        }
    }
}

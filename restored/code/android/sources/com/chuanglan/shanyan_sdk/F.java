package com.chuanglan.shanyan_sdk;

import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Movie;
import android.graphics.Paint;
import android.graphics.drawable.BitmapDrawable;
import android.os.Handler;
import android.view.View;
import java.io.IOException;
import java.io.InputStream;

/* JADX INFO: loaded from: classes2.dex */
public class F {
    public static final int j = Color.parseColor("#FFFFFF");
    private static volatile F k = null;
    private InputStream b;
    private View c;
    private Movie d;
    private Bitmap e;
    private Canvas f;
    private Paint h;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final long f1940a = 16;
    private Handler g = new Handler();
    private Runnable i = new a();

    class a implements Runnable {
        a() {
        }

        @Override // java.lang.Runnable
        public void run() {
            try {
                F.this.b();
                if (F.this.c != null) {
                    F.this.g.postDelayed(F.this.i, 16L);
                }
            } catch (Exception e) {
                e.printStackTrace();
                Q.d("ExceptionShanYanLogger", "GifDecoder  Exception_e=", e);
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b() {
        this.f.save();
        Paint paint = new Paint(1);
        this.h = paint;
        paint.setColor(j);
        this.h.setStyle(Paint.Style.FILL);
        this.h.setAntiAlias(true);
        this.h.setDither(true);
        this.f.drawPaint(this.h);
        this.d.setTime((int) (System.currentTimeMillis() % ((long) this.d.duration())));
        this.d.draw(this.f, 0.0f, 0.0f);
        BitmapDrawable bitmapDrawable = new BitmapDrawable(this.e);
        View view = this.c;
        if (view != null) {
            view.setBackground(bitmapDrawable);
        }
        this.f.restore();
    }

    public static F c() {
        if (k == null) {
            synchronized (F.class) {
                if (k == null) {
                    k = new F();
                }
            }
        }
        return k;
    }

    public F a(InputStream inputStream) {
        b(inputStream);
        return this;
    }

    public void a() {
        if (this.c != null) {
            this.c = null;
        }
    }

    public void a(View view) {
        this.c = view;
        InputStream inputStream = this.b;
        if (inputStream == null) {
            return;
        }
        if (view == null) {
            Q.d("ExceptionShanYanLogger", "imagetView can not be null");
            return;
        }
        Movie movieDecodeStream = Movie.decodeStream(inputStream);
        this.d = movieDecodeStream;
        if (movieDecodeStream == null) {
            Q.d("ExceptionShanYanLogger", "Illegal movie file");
        } else {
            if (movieDecodeStream.width() <= 0 || this.d.height() <= 0) {
                return;
            }
            this.e = Bitmap.createBitmap(this.d.width(), this.d.height(), Bitmap.Config.RGB_565);
            this.f = new Canvas(this.e);
            this.g.post(this.i);
        }
    }

    public void b(InputStream inputStream) {
        InputStream inputStream2 = this.b;
        if (inputStream2 != null) {
            try {
                inputStream2.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
        this.b = inputStream;
    }
}

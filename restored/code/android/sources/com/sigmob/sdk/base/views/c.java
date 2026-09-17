package com.sigmob.sdk.base.views;

import android.content.Context;
import android.graphics.Bitmap;
import android.media.MediaMetadataRetriever;
import android.media.MediaPlayer;
import android.os.Handler;
import android.os.Looper;
import android.view.SurfaceHolder;
import android.view.SurfaceView;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

/* JADX INFO: loaded from: classes3.dex */
public class c extends RelativeLayout implements MediaPlayer.OnBufferingUpdateListener, SurfaceHolder.Callback {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3312a = "AdVideoPlayer";
    private MediaPlayer b;
    private SurfaceHolder c;
    private SurfaceView d;
    private ImageView e;
    private String f;
    private int g;
    private int h;
    private int i;
    private a j;
    private MediaPlayer.OnPreparedListener k;
    private final ExecutorService l;
    private final Handler m;

    /* JADX INFO: renamed from: com.sigmob.sdk.base.views.c$1, reason: invalid class name */
    static /* synthetic */ class AnonymousClass1 {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f3313a;

        static {
            int[] iArr = new int[a.values().length];
            f3313a = iArr;
            try {
                iArr[a.FIT_SCREEN.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                f3313a[a.FILL_SCREEN.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                f3313a[a.ORIGINAL_SIZE.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
            try {
                f3313a[a.STRETCH_FILL.ordinal()] = 4;
            } catch (NoSuchFieldError unused4) {
            }
        }
    }

    public enum a {
        FIT_SCREEN,
        FILL_SCREEN,
        ORIGINAL_SIZE,
        STRETCH_FILL
    }

    public c(Context context) {
        super(context);
        this.f = "";
        this.g = 0;
        this.h = 0;
        this.j = a.FIT_SCREEN;
        this.l = Executors.newSingleThreadExecutor();
        this.m = new Handler(Looper.getMainLooper());
        a(context);
    }

    private void a(Context context) {
        this.e = new ImageView(context);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, -1);
        layoutParams.addRule(13);
        this.e.setLayoutParams(layoutParams);
        this.e.setScaleType(ImageView.ScaleType.CENTER_CROP);
        this.e.setBackgroundColor(-16777216);
        addView(this.e);
        this.d = new SurfaceView(context);
        RelativeLayout.LayoutParams layoutParams2 = new RelativeLayout.LayoutParams(-1, -1);
        layoutParams2.addRule(13);
        this.d.setLayoutParams(layoutParams2);
        addView(this.d);
        SurfaceHolder holder = this.d.getHolder();
        this.c = holder;
        holder.addCallback(this);
        MediaPlayer mediaPlayer = new MediaPlayer();
        this.b = mediaPlayer;
        mediaPlayer.setLooping(true);
        this.b.setOnBufferingUpdateListener(this);
        this.b.setOnPreparedListener(new MediaPlayer.OnPreparedListener() { // from class: com.sigmob.sdk.base.views.c$$ExternalSyntheticLambda2
            @Override // android.media.MediaPlayer.OnPreparedListener
            public final void onPrepared(MediaPlayer mediaPlayer2) {
                this.f$0.a(mediaPlayer2);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(Bitmap bitmap, String str) {
        this.e.setImageBitmap(bitmap);
        com.sigmob.sdk.base.utils.k.b(f3312a, "extractVideoFirstFrame: Successfully captured the first frame of the video(%s).", str);
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Code duplicated, block: B:12:0x0029  */
    public /* synthetic */ void a(MediaPlayer mediaPlayer) {
        this.g = mediaPlayer.getVideoWidth();
        this.h = mediaPlayer.getVideoHeight();
        int i = AnonymousClass1.f3313a[this.j.ordinal()];
        if (i == 1) {
            this.b.setVideoScalingMode(1);
        } else if (i == 2 || i == 3) {
            this.b.setVideoScalingMode(2);
        } else if (i == 4) {
            this.b.setVideoScalingMode(1);
        }
        requestLayout();
        invalidate();
        MediaPlayer.OnPreparedListener onPreparedListener = this.k;
        if (onPreparedListener == null) {
            return;
        }
        onPreparedListener.onPrepared(mediaPlayer);
    }

    private void a(final String videoPath) {
        if (videoPath == null || videoPath.isEmpty() || videoPath.startsWith("http://") || videoPath.startsWith("https://")) {
            return;
        }
        this.l.execute(new Runnable() { // from class: com.sigmob.sdk.base.views.c$$ExternalSyntheticLambda1
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.b(videoPath);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(final String str) {
        try {
            MediaMetadataRetriever mediaMetadataRetriever = new MediaMetadataRetriever();
            try {
                mediaMetadataRetriever.setDataSource(str);
                Bitmap frameAtTime = mediaMetadataRetriever.getFrameAtTime(0L, 2);
                if (frameAtTime == null) {
                    com.sigmob.sdk.base.utils.k.e(f3312a, "extractVideoFirstFrame: Failed to retrieve the first frame of the video(%s).", str);
                } else {
                    com.sigmob.sdk.base.blurkit.a.a(getContext());
                    final Bitmap bitmapA = com.sigmob.sdk.base.blurkit.a.a().a(frameAtTime, 25, 1.0f);
                    this.m.post(new Runnable() { // from class: com.sigmob.sdk.base.views.c$$ExternalSyntheticLambda0
                        @Override // java.lang.Runnable
                        public final void run() {
                            this.f$0.a(bitmapA, str);
                        }
                    });
                }
                mediaMetadataRetriever.close();
            } catch (Throwable th) {
                try {
                    mediaMetadataRetriever.close();
                } catch (Throwable th2) {
                    th.addSuppressed(th2);
                }
                throw th;
            }
        } catch (Exception e) {
            com.sigmob.sdk.base.utils.k.f(f3312a, "extractVideoFirstFrame: error = " + e.getMessage(), new Object[0]);
        }
    }

    /* JADX WARN: Code duplicated, block: B:24:0x0056  */
    /* JADX WARN: Code duplicated, block: B:25:0x005b  */
    private void h() {
        int i;
        int i2;
        int iMin;
        int measuredWidth = getMeasuredWidth();
        int measuredHeight = getMeasuredHeight();
        if (measuredWidth == 0 || measuredHeight == 0 || (i = this.g) <= 0 || (i2 = this.h) <= 0) {
            return;
        }
        float f = i / i2;
        float f2 = measuredWidth;
        float f3 = measuredHeight;
        float f4 = f2 / f3;
        RelativeLayout.LayoutParams layoutParams = (RelativeLayout.LayoutParams) this.d.getLayoutParams();
        int i3 = AnonymousClass1.f3313a[this.j.ordinal()];
        if (i3 != 1) {
            if (i3 != 2) {
                if (i3 != 3) {
                    layoutParams.width = measuredWidth;
                    layoutParams.height = measuredHeight;
                } else {
                    layoutParams.width = Math.min(this.g, measuredWidth);
                    iMin = Math.min(this.h, measuredHeight);
                    layoutParams.height = iMin;
                }
            } else if (f > f4) {
                layoutParams.height = measuredHeight;
                layoutParams.width = (int) (f3 * f);
            } else {
                layoutParams.width = measuredWidth;
                iMin = (int) (f2 / f);
                layoutParams.height = iMin;
            }
        } else if (f > f4) {
            layoutParams.width = measuredWidth;
            iMin = (int) (f2 / f);
            layoutParams.height = iMin;
        } else {
            layoutParams.height = measuredHeight;
            layoutParams.width = (int) (f3 * f);
        }
        layoutParams.addRule(13);
        layoutParams.leftMargin = 0;
        layoutParams.topMargin = 0;
        this.d.setLayoutParams(layoutParams);
    }

    private void i() {
        String str = this.f;
        if (str == null || str.isEmpty()) {
            return;
        }
        try {
            this.b.reset();
            this.b.setDataSource(this.f);
            this.b.prepareAsync();
        } catch (Exception e) {
            com.sigmob.sdk.base.utils.k.f(f3312a, "play: error = " + e.getMessage(), new Object[0]);
        }
    }

    public void a() {
        MediaPlayer mediaPlayer = this.b;
        if (mediaPlayer == null || !mediaPlayer.isPlaying()) {
            return;
        }
        this.b.pause();
        this.i = this.b.getCurrentPosition();
        com.sigmob.sdk.videoplayer.c.g(getContext());
    }

    public void a(int position) {
        MediaPlayer mediaPlayer = this.b;
        if (mediaPlayer == null) {
            return;
        }
        mediaPlayer.seekTo(position);
    }

    public void a(int width, int height) {
        this.g = width;
        this.h = height;
    }

    public void a(boolean mute) {
        MediaPlayer mediaPlayer = this.b;
        if (mediaPlayer == null) {
            return;
        }
        float f = mute ? 0.0f : 1.0f;
        mediaPlayer.setVolume(f, f);
    }

    public void b() {
        MediaPlayer mediaPlayer = this.b;
        if (mediaPlayer == null) {
            return;
        }
        mediaPlayer.seekTo(this.i);
        this.b.start();
        com.sigmob.sdk.videoplayer.c.f(getContext());
    }

    public void c() {
        MediaPlayer mediaPlayer = this.b;
        if (mediaPlayer == null) {
            return;
        }
        if (mediaPlayer.isPlaying()) {
            this.b.stop();
        }
        this.b.reset();
        this.b.release();
        this.b = null;
        this.l.shutdown();
    }

    public void d() {
        MediaPlayer mediaPlayer = this.b;
        if (mediaPlayer != null) {
            mediaPlayer.start();
        }
        com.sigmob.sdk.videoplayer.c.f(getContext());
    }

    public void e() {
        MediaPlayer mediaPlayer = this.b;
        if (mediaPlayer == null) {
            return;
        }
        mediaPlayer.stop();
    }

    public void f() {
        MediaPlayer mediaPlayer = this.b;
        if (mediaPlayer == null) {
            return;
        }
        mediaPlayer.pause();
    }

    public boolean g() {
        MediaPlayer mediaPlayer = this.b;
        return mediaPlayer != null && mediaPlayer.isPlaying();
    }

    public ImageView getBackgroundImageView() {
        return this.e;
    }

    public a getScaleMode() {
        return this.j;
    }

    public int getVideoHeight() {
        return this.h;
    }

    public int getVideoWidth() {
        return this.g;
    }

    @Override // android.media.MediaPlayer.OnBufferingUpdateListener
    public void onBufferingUpdate(MediaPlayer mp, int percent) {
    }

    @Override // android.widget.RelativeLayout, android.view.ViewGroup, android.view.View
    protected void onLayout(boolean changed, int left, int top, int right, int bottom) {
        super.onLayout(changed, left, top, right, bottom);
        if (changed) {
            h();
        }
    }

    @Override // android.widget.RelativeLayout, android.view.View
    protected void onMeasure(int widthMeasureSpec, int heightMeasureSpec) {
        super.onMeasure(widthMeasureSpec, heightMeasureSpec);
        h();
    }

    @Override // android.view.View
    public void setBackgroundColor(int color) {
        ImageView imageView = this.e;
        if (imageView == null) {
            return;
        }
        imageView.setBackgroundColor(color);
    }

    public void setBackgroundImage(Bitmap bitmap) {
        ImageView imageView = this.e;
        if (imageView == null || bitmap == null) {
            return;
        }
        imageView.setImageBitmap(bitmap);
    }

    @Override // android.view.View
    public void setBackgroundResource(int resId) {
        ImageView imageView = this.e;
        if (imageView == null) {
            return;
        }
        imageView.setImageResource(resId);
    }

    public void setOnPreparedListener(MediaPlayer.OnPreparedListener listener) {
        this.k = listener;
    }

    public void setOnSeekCompleteListener(MediaPlayer.OnSeekCompleteListener onSeekCompleteListener) {
        this.b.setOnSeekCompleteListener(onSeekCompleteListener);
    }

    public void setScaleMode(a scaleMode) {
        if (this.j == scaleMode) {
            return;
        }
        this.j = scaleMode;
        requestLayout();
    }

    public void setVideoPath(String videoPath) {
        this.f = videoPath;
        if (this.b == null) {
            return;
        }
        i();
    }

    public void setVolume(float volume) {
        MediaPlayer mediaPlayer = this.b;
        if (mediaPlayer == null) {
            return;
        }
        mediaPlayer.setVolume(volume, volume);
    }

    @Override // android.view.SurfaceHolder.Callback
    public void surfaceChanged(SurfaceHolder holder, int format, int width, int height) {
        requestLayout();
    }

    @Override // android.view.SurfaceHolder.Callback
    public void surfaceCreated(SurfaceHolder holder) {
        MediaPlayer mediaPlayer = this.b;
        if (mediaPlayer == null) {
            return;
        }
        mediaPlayer.setDisplay(holder);
        String str = this.f;
        if (str == null || str.isEmpty()) {
            return;
        }
        i();
    }

    @Override // android.view.SurfaceHolder.Callback
    public void surfaceDestroyed(SurfaceHolder holder) {
        MediaPlayer mediaPlayer = this.b;
        if (mediaPlayer == null) {
            return;
        }
        mediaPlayer.setDisplay(null);
    }
}
